using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class TownshipQuarter
    {
       
        [Key]
        public int QuarterId { get; set; }
        public string QuarterDescription { get; set; }
        public string QuarterCode { get; set; }
        public bool Isoccupied { get; set; }        
        public int UserId { get; set; }
        public DateTime OccupiedDate { get; set; }
        [ForeignKey(nameof(TypeIndicator))]
        public int TypeId { get; set; }
    }
}
