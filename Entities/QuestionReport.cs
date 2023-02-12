using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealDiscuss.Entities
{
    public class QuestionReport : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int CommentId { get; set; }
        public Question Question { get; set; }
        public string AdditionalComment { get; set; }
        public ICollection<QuestionReportFlag> QuestionReportFlags { get; set; } = new HashSet<QuestionReportFlag>();
    }
}