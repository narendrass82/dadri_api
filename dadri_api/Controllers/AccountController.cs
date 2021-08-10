using AutoMapper;
using dadri_api.Data;
using dadri_api.IRepository;
using dadri_api.Models;
using dadri_api.Services;
using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace dadri_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApiUser> _userManager;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;
        private readonly IAuthManager _authManager;        
        private readonly IUnitOfWork _unitOfWork;
        private string GetCurrentUserEmail()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.Name);
            return claim?.Value;
        }
        public AccountController(UserManager<ApiUser> userManager,
            ILogger<AccountController> logger,
            IMapper mapper, IAuthManager authManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _mapper = mapper;
            _logger = logger;
            _authManager = authManager;
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        [Authorize(Roles ="Role,Super,Admin,Administrator")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserDTO userDTO)
        {
            _logger.LogInformation($"Registration attempt for {userDTO.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = _mapper.Map<ApiUser>(userDTO);
            user.UserName = user.Email;
            var result = await _userManager.CreateAsync(user, userDTO.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);

                }
                return BadRequest(ModelState);
            }
            var xx= await _userManager.AddToRolesAsync(user, userDTO.Roles);            
            return Ok(new Models.Response { Data=xx,Message="User Registered by admin",Status=true,StatusCode=StatusCodes.Status201Created});
        }

        [HttpPost]
        [Route("UserRegister")]
        [HttpCacheExpiration(CacheLocation = CacheLocation.Private, MaxAge = 55)]
        [HttpCacheValidation(MustRevalidate = true)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status208AlreadyReported)]
        public async Task<IActionResult> UserRegister([FromBody] UserRegisterCreateDTO registerDTO)
        {

            _logger.LogInformation($"Registration Attempted for {registerDTO.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = _mapper.Map<UserRegister>(registerDTO);
            var resultEmail = await _unitOfWork.UserRegisters.Get(u => u.Email == user.Email );           
            
            if (resultEmail != null)
            {
                if (resultEmail.IsApproved)
                {
                    return Ok(new Response { StatusCode = StatusCodes.Status208AlreadyReported, Data = $"Already approved email {user.Email} and mobile {user.PhoneNumber}. You don't required for register. You may login.", Status = true, Message = "User already registered." });
                }
                return Ok(new Response { StatusCode = StatusCodes.Status208AlreadyReported, Data = null, Status = true, Message = $"User already registered with email {user.Email} and mobile {user.PhoneNumber}. Please contact system adminstration for approval." });
            }
            string userIpAddress = this.Request.HttpContext.GetServerVariable("REMOTE_ADDR");                        
            if (user.Ip == null || user.Ip.Length<7)
            {                
                if (String.IsNullOrEmpty(userIpAddress))
                    userIpAddress = "";
                user.Ip = userIpAddress;
            }
            user.IsApproved = false;
            user.RegistratinDate = DateTime.Now;            
            await _unitOfWork.UserRegisters.Insert(user);
            await _unitOfWork.Save();
            return Ok(new Response { StatusCode = StatusCodes.Status201Created, Data = user, Status = true, Message = "your registration is successfully. It will process within 24 hours for login." });

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDTO userDTO)
        {

            _logger.LogInformation($"Login attempt for {userDTO.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!await _authManager.ValidateUser(userDTO))
            {
                return Unauthorized(new Response { StatusCode = StatusCodes.Status401Unauthorized, Data = userDTO, Status = true, Message = "validation falied." });
            }

            return Accepted(new { Token = await _authManager.CreateToken() });
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("PasswordReset")]
        public async Task<IActionResult> PasswordReset([FromBody] UserPasswordResetDTO userDTO)
        {
           
            _logger.LogInformation($"Reset Password attempt for {userDTO.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var userOld = new LoginUserDTO { Email=userDTO.Email,Password=userDTO.OldPassword};
            if (!await _authManager.ValidateUser(userOld))
            {
                return Unauthorized(new Response { StatusCode = StatusCodes.Status401Unauthorized, Data = userDTO, Status = true, Message = "validation falied." });
            }
            if (!userDTO.NewPassword.Equals(userDTO.NewPasswordConfirm))
            {                
                return BadRequest(new { StatusCode=StatusCodes.Status400BadRequest,Message="Mismatch new password and confirm password"});
            }
            
            var user = await _userManager.FindByEmailAsync(userDTO.Email);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var xx = await _userManager.ResetPasswordAsync(user, token, userDTO.NewPassword);
            return Accepted(new Response { StatusCode = StatusCodes.Status202Accepted, Data = xx, Status = true, Message = "Password changed." });
            
        }
        [Authorize(Roles = "Super,Admin,Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("PasswordResetByAdmin")]
        public async Task<IActionResult> PasswordResetByAdmin([FromBody] UserPasswordResetByAdminDTO userDTO)
        {
            var userEmail = GetCurrentUserEmail();
            _logger.LogInformation($"Reset Password attempt for {userDTO.Email} by {userEmail}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }            
            if (userDTO.IsAutoGenerate)
            {
                var user = await _userManager.FindByEmailAsync(userDTO.Email);
                if (user==null)
                {
                    return BadRequest(new { StatusCode = StatusCodes.Status400BadRequest, Message = "user does not exist." });
                }
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                userDTO.NewPassword = GeneralFunctions.GetUniqueKey(5)+"A1*";
                _logger.LogInformation($"Reset Password attempt for {userDTO.Email} by {userEmail} is {userDTO.NewPassword}");
                return Accepted(await _userManager.ResetPasswordAsync(user, token, userDTO.NewPassword));
            }
            if (userDTO.NewPassword == null || userDTO.NewPasswordConfirm == null)
            {
                return BadRequest(new { StatusCode = StatusCodes.Status400BadRequest, Message = "Password is not define." });
            }
            if (userDTO.NewPassword==null || userDTO.NewPasswordConfirm == null || !(userDTO.NewPassword.Equals(userDTO.NewPasswordConfirm)))
            {
                return BadRequest(new { StatusCode = StatusCodes.Status400BadRequest, Message = "Mismatch new password and confirm password." });
            }
            if (userDTO.NewPasswordConfirm.Length<=7)
            {
                return BadRequest(new { StatusCode = StatusCodes.Status400BadRequest, Message = "Password must greater than 8 character." });
            }
            var user1 = await _userManager.FindByEmailAsync(userDTO.Email);
            var token1 = await _userManager.GeneratePasswordResetTokenAsync(user1);
            var xx = await _userManager.ResetPasswordAsync(user1, token1, userDTO.NewPassword);
            _logger.LogInformation($"Reset Password attempt for {userDTO.Email} by {userEmail} is {userDTO.NewPassword}");
            return Accepted(new Response { StatusCode = StatusCodes.Status202Accepted, Data = xx, Status = true, Message = "Password changed by admin." });
        }
        [Authorize(Roles = "Super,Admin,Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("DeleteUserByAdmin")]
        public async Task<IActionResult> DeleteUserByAdmin([FromBody] UserDeleteByAdminDTO userDTO)
        {
            var userEmail = GetCurrentUserEmail();
            _logger.LogInformation($"delete user attempt for {userDTO.Email} by {userEmail}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            if (userDTO.Email == null)
            {
                return BadRequest(new { StatusCode = StatusCodes.Status400BadRequest, Message = "Invalid email." });
            }
            
            var user = await _userManager.FindByEmailAsync(userDTO.Email);
            if (user== null)
            {
                return BadRequest(new { StatusCode = StatusCodes.Status400BadRequest, Message = "Invalid user." });
            }
            var rolesForUser = await _userManager.GetRolesAsync(user);
            if (rolesForUser.Count() > 0)
            {
                foreach (var item in rolesForUser.ToList())
                {
                    // item should be the name of the role
                    await _userManager.RemoveFromRoleAsync(user, item);
                }
            }
            var rc = await _userManager.DeleteAsync(user);
            _logger.LogInformation($"deleted user for {userDTO.Email} by {userEmail}");
            return Accepted(new Response { StatusCode = StatusCodes.Status202Accepted, Data = rc, Status = true, Message = "User deleted by admin." });
        }
        // all get methods does have only user role required 
        [HttpGet]
        [Authorize(Roles = "Role,Super,Admin,Administrator,User")]
        [HttpCacheExpiration(CacheLocation = CacheLocation.Private, MaxAge = 55)]
        [HttpCacheValidation(MustRevalidate = false)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("GetUserEmployers")]
        public async Task<IActionResult> GetUserEmployers()
        {
            var objList = await _unitOfWork.UserEmployers.GetAll();
            var results = _mapper.Map<List<UserEmployer>>(objList);
            return Ok(results);

        }
        [HttpGet]
        [Authorize(Roles = "Role,Super,Admin,Administrator,User")]
        [HttpCacheExpiration(CacheLocation = CacheLocation.Private, MaxAge = 55)]
        [HttpCacheValidation(MustRevalidate = false)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("GetUserProjects")]
        public async Task<IActionResult> GetUserProjects()
        {
            var objList = await _unitOfWork.UserProjects.GetAll();
            var results = _mapper.Map<List<UserProject>>(objList);
            return Ok(results);
        }
        [HttpGet]
        [Authorize(Roles = "Role,Super,Admin,Administrator,User")]
        [HttpCacheExpiration(CacheLocation = CacheLocation.Private, MaxAge = 55)]
        [HttpCacheValidation(MustRevalidate = false)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("GetUserDepts")]
        public async Task<IActionResult> GetUserDepts()
        {
            var objList = await _unitOfWork.UserDepts.GetAll();
            var results = _mapper.Map<List<UserDept>>(objList);
            return Ok(results);
        }
        [HttpGet]
        [Authorize(Roles = "Role,Super,Admin,Administrator,User")]
        [HttpCacheExpiration(CacheLocation = CacheLocation.Private, MaxAge = 55)]
        [HttpCacheValidation(MustRevalidate = false)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("GetUserGrades")]
        public async Task<IActionResult> GetUserGrades()
        {
            var objList = await _unitOfWork.UserGrades.GetAll();
            var results = _mapper.Map<List<UserGrade>>(objList);
            return Ok(results);
        }
        [HttpGet]
        [Authorize(Roles = "Role,Super,Admin,Administrator,User")]
        [HttpCacheExpiration(CacheLocation = CacheLocation.Private, MaxAge = 55)]
        [HttpCacheValidation(MustRevalidate = false)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("GetUserPersonalAreas")]
        public async Task<IActionResult> GetUserPersonalAreas()
        {
            var objList = await _unitOfWork.UserPersonalAreas.GetAll();
            var results = _mapper.Map<List<UserPersonalArea>>(objList);
            return Ok(results);
        }
        [HttpGet]
        [Authorize(Roles = "Role,Super,Admin,Administrator,User")]
        [HttpCacheExpiration(CacheLocation = CacheLocation.Private, MaxAge = 55)]
        [HttpCacheValidation(MustRevalidate = false)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var objList = _userManager.Users;
            var results = _mapper.Map<List<UserDTO>>(objList);
            for (int i = 0; i < results.Count(); i++)
            {
                var u = _userManager.Users.FirstOrDefault(x=>x.Email.ToLower().Equals(results[i].Email.ToLower()));
                results[i].Roles = await _userManager.GetRolesAsync(u);
            }
            return Ok(results);
        }
    }
}
