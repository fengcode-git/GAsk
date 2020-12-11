using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Paging;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    /// <summary>
    /// 首页视图模型
    /// </summary>
    public class HomeIndexModel
    {
        public PagingResult<PostView> PostViews { get; set; }
        public string Search { get; set; } = string.Empty;
        public PersonView LoginPerson { get; set; }
    }
}