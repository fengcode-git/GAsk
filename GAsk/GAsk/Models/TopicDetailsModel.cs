using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Paging;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    public class TopicDetailsModel
    {
        public Topic Topic { get; set; }
        public PagingResult<PostView> PagingResult { get; set; }
    }
}
