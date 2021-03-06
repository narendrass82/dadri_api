using AutoMapper;
using dadri_api.IRepository;
using dadri_api.Models;
using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CountryController> _logger;
        private readonly IMapper _mapper;
        public CountryController(IUnitOfWork unit, ILogger<CountryController> logger, IMapper mapper)
        {
            _unitOfWork = unit;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet] 
        [HttpCacheExpiration(CacheLocation =CacheLocation.Private,MaxAge =55)]
        [HttpCacheValidation(MustRevalidate =false)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountries()
        {

            var countries = await _unitOfWork.Countries.GetAll();
            var results = _mapper.Map<List<CountryDTO>>(countries);
            return Ok(results);

        }
        [HttpGet("(countryId:int)")]        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountry(int countryId)
        {            
            var country = await _unitOfWork.Countries.Get(q => q.CountryId == countryId, include: q => q.Include(x => x.Hotels));
            var result = _mapper.Map<CountryDTO>(country);
            return Ok(result);

        }
    }
}
