using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealDiscuss.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        
    }
}