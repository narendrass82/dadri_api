using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class UserRegister
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]        
        public int RegisterId { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Ip { get; set; }
        public string Mac { get; set; }
        public string DeviceName { get; set; }
        public bool IsApproved { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime RegistratinDate { get; set; }
        [ForeignKey(nameof(UserEmployer))]
        public int EmployerId { get; set; }
        [ForeignKey(nameof(UserProject))]
        public int ProjectId { get; set; }
        public UserEmployer UserEmployer { get; set; }

    }
}
