using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Paging;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    /// <summary>
    /// 问答首页模型
    /// </summary>
    public class QuestionIndexModel
    {
        public PagingResult<PostView> PostViews { get; set; }
    }
}
