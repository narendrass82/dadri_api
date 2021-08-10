using AutoMapper;
using dadri_api.Data;
using dadri_api.IRepository;
using dadri_api.Models;
using Microsoft.AspNetCore.Authorization;
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
    public class HotelController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<HotelController> _logger;
        private readonly IMapper _mapper;
        public HotelController(IUnitOfWork unit, ILogger<HotelController> logger, IMapper mapper)
        {
            _unitOfWork = unit;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        
        public async Task<IActionResult> GetHotels()
        {
            var hotels = await _unitOfWork.Hotels.GetAll();
            var results = _mapper.Map<List<HotelDTO>>(hotels);
            return Ok(results);

        } 
        [Authorize(Roles = "Administrator")]
        [HttpGet("{hotelId:int}",Name = "GetHotel")]
        [ProducesResponseType(StatusCodes.Status200OK)]        
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        
        public async Task<IActionResult> GetHotel(int hotelId)
        {
            var hotel = await _unitOfWork.Hotels.Get(q => q.HotelId == hotelId, include:q=>q.Include(x=>x.Country));
            var result = _mapper.Map<HotelDTO>(hotel);
            return Ok(result);

        }
        
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> CreateHotel([FromBody] CreateHotelDTO hotelDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var hotel = _mapper.Map<Hotel>(hotelDTO);
            await _unitOfWork.Hotels.Insert(hotel);
            await _unitOfWork.Save();
            return CreatedAtRoute("GetHotel", new { hotelId = hotel.HotelId },hotel);
        
        }
    }
}
