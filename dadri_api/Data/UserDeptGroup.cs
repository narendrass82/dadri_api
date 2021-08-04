using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class UserDeptGroup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        [Key]
        public int GroupId { get; set; }
        public string GroupDescription { get; set; }
        [ForeignKey(nameof(TypeIndicator))]
        public int TypeId { get; set; }
    }
}
