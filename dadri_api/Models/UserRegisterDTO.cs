using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Models
{
    public class UserRegisterDTO:UserRegisterCreateDTO
    {
        public int RegisterId { get; set; }        
        public bool IsApproved { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string ApprovedBy { get; set; }               
    }
    public class UserRegisterCreateDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(maximumLength: 100, MinimumLength = 5, ErrorMessage = "Value lenght must be 5 to 100")]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Value lenght must be 10")]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 1, ErrorMessage = "Value lenght must be 1 to 100")]
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string Ip { get; set; }
        public string Mac { get; set; }
        public string DeviceName { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 10)]
        public int EmployerId { get; set; }
        [Required]        
        [Range(minimum: 1000, maximum: 9999)]
        public int ProjectId { get; set; }
        public DateTime RegistratinDate => DateTime.Now;
    }
}
