using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class ApiUser : IdentityUser
    {
        public string EmpNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RegisterId { get; set; }
        public bool IsApproved { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime RegistratinDate { get; set; }

        [ForeignKey(nameof(UserEmployer))]
        public int EmployerId { get; set; }
        [ForeignKey(nameof(UserProject))]
        public int ProjectId { get; set; }
        [ForeignKey(nameof(UserGrade))]
        public int GradeId { get; set; }
        [ForeignKey(nameof(UserDept))]
        public int DeptId { get; set; }
        [ForeignKey(nameof(UserPersonalArea))]
        public int PersonalAreaId { get; set; }
        [ForeignKey(nameof(TownshipQuarter))]
        public int QuarterId { get; set; }
        public DateTime DOB { get; set; }
        public DateTime NTPCJoining { get; set; }
        public DateTime ProjectJoining { get; set; }
        public DateTime EntryIntoGrade { get; set; }
    }
}
