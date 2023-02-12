using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealDiscuss.Entities
{
    public class Category : BaseEntity
    
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CategoryQuestion> CategoryQuestions { get; set; } = new HashSet<CategoryQuestion>();
    }
}