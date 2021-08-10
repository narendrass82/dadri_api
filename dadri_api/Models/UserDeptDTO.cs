using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Models
{
    public class UserDeptDTO:UserDeptDTOCreate
    {
        public int DeptId { get; set; }
    }
    public class UserDeptDTOCreate
    {

        [Required]
        [DataType(DataType.Text)]
        public string DeptCode { get; set; }
        [Required]
        [StringLength(maximumLength: 200, ErrorMessage = "Length can't more than 200 character")]
        public string DeptDescription { get; set; }
        public int TypeId { get; set; }
    }
}
