using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Paging;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    /// <summary>
    /// 帖子列表视图模型
    /// </summary>
    public class PostListViewModel
    {
        public List<PostView> PostViews { get; set; } = new List<PostView>();
    }
}
