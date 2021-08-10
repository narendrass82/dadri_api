using AutoMapper;
using dadri_api.Data;
using dadri_api.IRepository;
using dadri_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class DeptController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DeptController> _logger;
        private readonly IMapper _mapper;
        private string GetCurrentUserEmail()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.Name);
            return claim?.Value;
        }
        public DeptController(IUnitOfWork unit, ILogger<DeptController> logger, IMapper mapper)
        {
            _unitOfWork = unit;
            _logger = logger;
            _mapper = mapper;
        }
        [Authorize]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUserDepts()
        {
            var objList = await _unitOfWork.UserDepts.GetAll();
            var results = _mapper.Map<List<UserDeptDTO>>(objList);
            return Ok(new Response { Data = results, Message = null, Status = true, StatusCode = StatusCodes.Status200OK });

        }
        [Authorize]
        [HttpGet("{id:int}", Name = "GetUserDept")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetUserDept(int id)
        {
            var obj = await _unitOfWork.UserDepts.Get(q => q.DeptId==id);
            if (obj == null)
            {
                return BadRequest(new Response { Data = id, Message = null, Status = true, StatusCode = StatusCodes.Status400BadRequest });
            }
            var result = _mapper.Map<UserDeptDTO>(obj);
            return Ok(new Response { Data = result, Message = null, Status = true, StatusCode = StatusCodes.Status200OK });

        }

        [Authorize(Roles = "Super,Admin,Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> CreateUserDept([FromBody] UserDeptDTOCreate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var obj = _mapper.Map<UserDept>(dto);
            await _unitOfWork.UserDepts.Insert(obj);
            await _unitOfWork.Save();
            _logger.LogInformation($"Successfully added in method {nameof(CreateUserDept)} of data {obj} by {GetCurrentUserEmail()}");
            return CreatedAtRoute("GetUserDept", new { id = obj.DeptId }, obj);
        }
        [Authorize(Roles = "Super,Admin,Administrator")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> UpdateUserDept(int id,[FromBody] UserDeptDTO dto)
        {
            if (!ModelState.IsValid || id<1)
            {
                _logger.LogError($"Invalid attempt in {nameof(UpdateUserDept)}");
                return BadRequest(new Response { Data = ModelState, Message = $"Invalid attempt in {nameof(UpdateUserDept)}", Status = true, StatusCode = StatusCodes.Status400BadRequest });
            }
            var obj = _mapper.Map<UserDept>(dto);
            var o_obj = await _unitOfWork.UserDepts.Get(q => q.DeptId == id);
            if (o_obj == null)
            {
                _logger.LogError($"Invalid attempt in {nameof(UpdateUserDept)}");
                return BadRequest(new Response { Data = obj, Message = "Submitted data is invalid", Status = true, StatusCode = StatusCodes.Status400BadRequest });
            }
            _unitOfWork.UserDepts.Update(obj);
            await _unitOfWork.Save();
            _logger.LogInformation($"Successfully updated in method {nameof(UpdateUserDept)} of data {obj} by {GetCurrentUserEmail()}");
            return NoContent();
        }
        [Authorize(Roles = "Super,Admin,Administrator")]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> DeleteUserDept(int id)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid attempt in {nameof(DeleteUserDept)}");
                return BadRequest(new Response { Data = ModelState, Message = $"Invalid attempt in {nameof(DeleteUserDept)}", Status = true, StatusCode = StatusCodes.Status400BadRequest });
            }
            
            var o_obj = await _unitOfWork.UserDepts.Get(q => q.DeptId == id);
            if (o_obj == null)
            {
                _logger.LogError($"Invalid attempt in {nameof(DeleteUserDept)}");
                return BadRequest(new Response { Data = null, Message = "Submitted data is invalid", Status = true, StatusCode = StatusCodes.Status400BadRequest });
            }
            await _unitOfWork.UserDepts.Delete(o_obj.DeptId);
            await _unitOfWork.Save();
            _logger.LogInformation($"Successfully deleted in method {nameof(DeleteUserDept)} of data {o_obj} by {GetCurrentUserEmail()}");
            return NoContent();
        }
    }
}
