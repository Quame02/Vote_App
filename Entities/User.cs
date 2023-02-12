using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealDiscuss.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }

    }
}