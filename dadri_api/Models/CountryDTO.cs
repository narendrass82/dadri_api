using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Models
{
    public class CreateCountryDTO
    {

        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Country Name must be 3 to 100")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, MinimumLength = 1, ErrorMessage = "Country ShortName must be 1 to 2")]
        public string ShortName { get; set; }
    }
    public class CountryDTO: CreateCountryDTO
    {
        public int CountryId { get; set; }
        public virtual IList<HotelDTO> Hotels { get; set; }
    }
    
}
