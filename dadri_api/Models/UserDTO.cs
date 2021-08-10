using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Models
{
    public class LoginUserDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength: 15, ErrorMessage = "Your password is limited to {2} to {1} characters", MinimumLength = 4)]
        public string Password { get; set; }
    }
    public class UserPasswordResetDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength: 15, ErrorMessage = "Your password is limited to {2} to {1} characters", MinimumLength = 4)]
        public string OldPassword { get; set; }
        [Required]
        [StringLength(maximumLength: 15, ErrorMessage = "Your password is limited to {2} to {1} characters", MinimumLength = 4)]
        public string NewPassword { get; set; }
        [Required]
        [StringLength(maximumLength: 15, ErrorMessage = "Your password is limited to {2} to {1} characters", MinimumLength = 4)]
        public string NewPasswordConfirm { get; set; }
    }
    public class UserPasswordResetByAdminDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]        
        public bool IsAutoGenerate { get; set; }                
        public string NewPassword { get; set; }
        public string ResetBy { get; set; }
        public string NewPasswordConfirm { get; set; }
    }
    public class UserDeleteByAdminDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]        
        public string DeleteBy { get; set; }
       
    }
    public class UserDTO:LoginUserDTO
    {
        public string EmpNo { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]        
        public int RegisterId { get; set; }
        [Required]
        public bool IsApproved { get; set; }
        public DateTime ApprovalDate { get; set; }
        [Required]
        public string ApprovedBy { get; set; }
        public DateTime RegistratinDate { get; set; }
        [Required]
        public int EmployerId { get; set; }
        [Required]
        public int ProjectId { get; set; }
        [Required]
        public int GradeId { get; set; }
        [Required]
        public int DeptId { get; set; }
        [Required]
        public int PersonalAreaId { get; set; }
        [Required]
        public int QuarterId { get; set; }
        public DateTime DOB { get; set; }
        public DateTime NTPCJoining { get; set; }
        public DateTime ProjectJoining { get; set; }
        public DateTime EntryIntoGrade { get; set; }   
        public ICollection<string> Roles { get; set; }

    }    
}
