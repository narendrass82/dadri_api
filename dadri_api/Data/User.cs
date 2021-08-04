using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserId { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpNo { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Email2 { get; set; }
        public string Mobile2 { get; set; }
        public string IntercomH { get; set; }
        public string IntercomO { get; set; }
        public string IntercomH2 { get; set; }
        public string IntercomO2 { get; set; }
        public DateTime DOB { get; set; }
        public DateTime NTPCJoining { get; set; }
        public DateTime ProjectJoining { get; set; }
        public DateTime EntryIntoGrade { get; set; }
        [ForeignKey(nameof(UserDept))]
        public int DeptId { get; set; }
        [ForeignKey(nameof(UserGrade))]
        public int GradeId { get; set; }
        [ForeignKey(nameof(UserProject))]
        public int ProjectCodeId { get; set; }
        [ForeignKey(nameof(UserPersonalArea))]
        public int PersonalAreaId { get; set; }
        public string ProfilePathImage { get; set; }
        [ForeignKey(nameof(TownshipQuarter))]
        public int QuarterId { get; set; }
        [ForeignKey(nameof(TownshipQuarter))]
        public int QuarterId2 { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey(nameof(UserEmployer))]
        public int EmployerId { get; set; }
        public string Ip { get; set; }
        public string Mac { get; set; }
        public string DeviceName { get; set; }
        public bool IsApproved { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime RegistratinDate { get; set; }

        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        [ForeignKey(nameof(TypeIndicator))]
        public int TypeId { get; set; }
        

    }
}
