using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealDiscuss.Entities
{
    public class CategoryQuestion : BaseEntity
    {
        // public string Name { get; set; }
        // public string Description { get; set; }
        // public ICollection<CategoryQuestion>

        public int categoryId { get; set; }
        public Category Category { get; set;}
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}