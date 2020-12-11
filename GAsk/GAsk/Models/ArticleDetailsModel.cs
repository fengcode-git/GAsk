using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    public class ArticleDetailsModel
    {
        public Post Post { get; set; }
        /// <summary>
        /// 文章发布者
        /// </summary>
        public PersonView Person { get; set; }
    }
}
