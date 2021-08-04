using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class UserEmployer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        [Key]
        public int EmployerId { get; set; }
        public string EmployerName { get; set; }
        public int TypeId { get; set; }        
    }
}
