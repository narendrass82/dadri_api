using AutoMapper;
using dadri_api.IRepository;
using dadri_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Controllers
{
    [ApiVersion("2.0",Deprecated =true)]
    [Route("api/{v:apiversion}/Country")]
    [ApiController]
    public class CountryV2Controller : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CountryController> _logger;
        private readonly IMapper _mapper;
        public CountryV2Controller(IUnitOfWork unit, ILogger<CountryController> logger, IMapper mapper)
        {
            _unitOfWork = unit;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        [ResponseCache(CacheProfileName = "60SecondsDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountries()
        {

            var countries = await _unitOfWork.Countries.GetAll();
            var results = _mapper.Map<List<CountryDTO>>(countries);
            return Ok(results);

        }
    }
}
