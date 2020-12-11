using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Time;
using GAsk.Library.DAL;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    public class PostItemViewModel
    {
        public PostView PostView { get; set; }
        public List<Tag> Tags { get; set; } = new List<Tag>();

        public PostItemViewModel(PostView postView, List<Tag> tags)
        {
            PostView = postView ?? throw new ArgumentNullException(nameof(postView));
            this.Tags = tags;
        }

        public string GetPublishTime()
        {
            return DateTimeHelper.DateStringFromNow(this.PostView.CreateTime);
        }
    }
}
