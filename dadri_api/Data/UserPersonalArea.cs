using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class UserPersonalArea
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        [Key]
        public int PersonalAreaId { get; set; }
        public string PersonalAreaDescription { get; set; }
        public string PersonalAreaCode { get; set; }
        [ForeignKey(nameof(TypeIndicator))]
        public int TypeId { get; set; }
    }
}
