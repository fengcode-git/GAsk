using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    public class QuestionItemComponentModel
    {
        public PostView PostView { get; }

        public QuestionItemComponentModel(PostView postView)
        {
            PostView = postView ?? throw new ArgumentNullException(nameof(postView));
        }
    }
}
