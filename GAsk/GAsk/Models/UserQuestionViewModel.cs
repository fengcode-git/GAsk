using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Paging;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    public class UserQuestionViewModel
    {
        public PagingResult<PostView> PagingResult { get; }
        public PersonView PersonView { get; }

        public UserQuestionViewModel(PagingResult<PostView> pagingResult, PersonView personView)
        {
            PagingResult = pagingResult ?? throw new ArgumentNullException(nameof(pagingResult));
            PersonView = personView ?? throw new ArgumentNullException(nameof(personView));
        }
    }
}
