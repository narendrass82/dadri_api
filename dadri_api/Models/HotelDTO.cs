using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Models
{
    public class CreateHotelDTO
    {

        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Hotel Name must be 3 to 100")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Hotel Address must be 3 to 100")]
        public string Address { get; set; }

        [Required]
        [Range(minimum: 1, maximum: 5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
    public class HotelDTO: CreateHotelDTO
    {
        public int HotelId { get; set; }
        public CountryDTO Country { get; set;}        
    }
    
}
