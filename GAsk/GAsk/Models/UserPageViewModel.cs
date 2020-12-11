using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Paging;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    /// <summary>
    /// 用户主页视图模型
    /// </summary>
    public class UserPageViewModel
    {
        public PersonView PersonView { get; set; }
        public PagingResult<ActivityView> PagingResult { get; set; }

        public UserPageViewModel(PersonView personView, PagingResult<ActivityView> pagingResult)
        {
            PersonView = personView ?? throw new ArgumentNullException(nameof(personView));
            PagingResult = pagingResult ?? throw new ArgumentNullException(nameof(pagingResult));
        }
    }
}
