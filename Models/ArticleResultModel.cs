using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBlog2.Model
{
    public class ArticelResultModel
    {
        public int ArticleId { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
