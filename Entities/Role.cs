using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealDiscuss.Entities
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}