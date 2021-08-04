using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class UserProject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        [Key]
        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
        [ForeignKey(nameof(TypeIndicator))]
        public int TypeId { get; set; }
    }
}
