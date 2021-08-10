using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Models
{
    public class ProjectDTO
    {
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }        
        public int TypeId { get; set; }
    }
}
