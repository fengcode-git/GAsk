using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Paging;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    /// <summary>
    /// 文章首页模型
    /// </summary>
    public class ArticleIndexModel
    {
        public PagingResult<PostView> PostViews { get; set; }
    }
}


