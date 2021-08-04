using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class UserDept
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        [Key]
        public int DeptId { get; set; }
        public string DeptCode { get; set; }
        public string DeptDescription { get; set; }
        [ForeignKey(nameof(UserDeptGroup))]
        public int GroupId { get; set; }
        [ForeignKey(nameof(TypeIndicator))]
        public int TypeId { get; set; }
        public UserDeptGroup UserDeptGroup { get; set; }
    }
}
