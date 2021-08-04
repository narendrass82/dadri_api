using AutoMapper;
using dadri_api.IRepository;
using dadri_api.Models;
using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserApprovalController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UserApprovalController> _logger;
        private readonly IMapper _mapper;

        public UserApprovalController(IUnitOfWork unit, ILogger<UserApprovalController> logger, IMapper mapper)
        {
            _unitOfWork = unit;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        [HttpCacheExpiration(CacheLocation = CacheLocation.Private, MaxAge = 55)]
        [HttpCacheValidation(MustRevalidate = false)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ApproveRegisterUser([FromBody] UsersApproveResgisterDTO approvalemails)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var obj = _mapper.Map<UsersApproveResgister>(approvalemails);
            //find valid token & user right
            var login = await _unitOfWork.UserLogins.Get(u => u.TokenId == obj.TokenId);
            if (login == null)
            {
                return Ok(new Models.Response { StatusCode = StatusCodes.Status401Unauthorized, Data = null, Status = true, Message = "Invalid token Identity" });
            }
            //find user
            var user = await _unitOfWork.Users.Get(u => u.UserId == login.UserId);
            if (user == null)
            {
                return Ok(new Models.Response { StatusCode = StatusCodes.Status401Unauthorized, Data = null, Status = true, Message = "Invalid token Identity" });
            }
            //find roles
            var roles = await _unitOfWork.UserRoles.GetAll(r => r.UserId == user.UserId && r.URoleId == 1);
            if (roles == null)
            {
                return Ok(new Models.Response { StatusCode = StatusCodes.Status401Unauthorized, Data = null, Status = true, Message = "You are not authorized." });
            }
            //now convert to data into desired form         
            foreach (var item in obj.Emails)
            {
                var register= await _unitOfWork.UserRegisters.Get(i => i.Email == item);
                register.IsApproved = true;
                register.ApprovedBy = user.UserId.ToString();
                register.ApprovalDate = DateTime.Now;
                var u = _mapper.Map<UserRegisterDTO>(register);

            }

            return Ok(new Models.Response { StatusCode = StatusCodes.Status201Created, Data = user, Status = true, Message = "your registration is successfully. It will process within 24 hours for login." });

        }
    }
}
