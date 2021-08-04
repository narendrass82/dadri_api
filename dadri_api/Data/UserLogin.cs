using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class UserLogin
    {
        [Key]        
        [ForeignKey(nameof(User))]         
        public int UserId { get; set; }        
        public string Password { get; set; }
        public string TokenId { get; set; }
        public string Otp { get; set; }
        public string OtpTemp { get; set; }
        public DateTime OtpGenerateDate { get; set; }
        public string DeviceIp { get; set; }
        public string DeviceMac { get; set; }
        public string DeviceName { get; set; }
        public string DeviceType { get; set; }
        [ForeignKey(nameof(TypeIndicator))]
        public int TypeId { get; set; }
        public User User { get; set; }
    }
}
