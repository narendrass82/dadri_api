using AutoMapper;
using dadri_api.Data;
using dadri_api.IRepository;
using dadri_api.Models;
using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegisterController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UserRegisterController> _logger;
        private readonly IMapper _mapper;

        public UserRegisterController(IUnitOfWork unit, ILogger<UserRegisterController> logger, IMapper mapper)
        {
            _unitOfWork = unit;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        [HttpCacheExpiration(CacheLocation = CacheLocation.Private, MaxAge = 55)]
        [HttpCacheValidation(MustRevalidate = false)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUserRegister()
        {
            var objList = await _unitOfWork.UserRegisters.GetAll();
            var results = _mapper.Map<List<UserRegisterDTO>>(objList);
            return Ok(results);

        }
        [HttpPost]
        [Route("UserRegister")]
        [HttpCacheExpiration(CacheLocation = CacheLocation.Private, MaxAge = 55)]
        [HttpCacheValidation(MustRevalidate = false)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]        
        public async Task<IActionResult> UserRegister([FromBody] UserRegisterCreateDTO registerDTO)
        {
            
            _logger.LogInformation($"Registration Attempted for {registerDTO.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = _mapper.Map<UserRegister>(registerDTO);
            var results = await _unitOfWork.UserRegisters.Get(u=>u.Email==user.Email || u.Mobile==user.Mobile);
            if (results != null)
            {
                if (results.IsApproved)
                {
                    return Ok(new Models.Response { StatusCode = StatusCodes.Status208AlreadyReported, Data = user, Status = true, Message = "User already registered with same email or mobile number. Please login with registered details" });
                }
                return Ok(new Models.Response {StatusCode=StatusCodes.Status208AlreadyReported, Data=results,Status=true,Message="User already registered with same email or mobile number. Please contact system adminstration for approval"});
            }
            
            user.IsApproved = false;
            if (user.Ip == null)
            {
                var address = Request.Headers["Host"];               
                if (String.IsNullOrEmpty(address))
                    address = "";
                user.Ip = address;
            }
            await _unitOfWork.UserRegisters.Insert(user);
            await _unitOfWork.Save();
            return Ok(new Models.Response { StatusCode = StatusCodes.Status201Created,Data = user, Status = true, Message = "your registration is successfully. It will process within 24 hours for login." });

        }
    }
}
