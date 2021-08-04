using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class TypeIndicator
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        [Key]
        public int TypeId { get; set; }
        public string TypeDescription { get; set; }
    }
}
