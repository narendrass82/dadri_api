using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class UserRole
    {  
        public string RoleId { get; set; }        
        public string Email { get; set; }        
        public int TypeId { get; set; }
    }
}
