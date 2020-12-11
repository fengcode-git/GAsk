using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    /// <summary>
    /// 最新推荐文章
    /// </summary>
    public class NewBestArticleComponentModel
    {
        public List<PostView> Posts { get; set; } = new List<PostView>();
    }
}

