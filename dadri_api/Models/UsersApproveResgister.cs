using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Models
{
    public class UsersApproveResgister
    {
        public string TokenId { get; set; }
        public IList<string> Emails { get; set; }
    }
    public class UsersApproveResgisterDTO
    {
        public string TokenId { get; set; }
        public IList<string> Emails { get; set; }
    }
}
