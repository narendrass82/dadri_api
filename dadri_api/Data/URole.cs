using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class URole
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]       
        [Key]
        public int URoleId { get; set; }
        public string RoleDescription { get; set; }
        public string RoleCode { get; set; }
        public bool IsDefault { get; set; }
        [ForeignKey(nameof(TypeIndicator))]
        public int TypeId { get; set; }
    }
}
