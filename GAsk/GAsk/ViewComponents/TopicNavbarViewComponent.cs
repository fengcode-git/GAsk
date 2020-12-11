using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using GAsk.Library.BBL;
using GAsk.Library.Entity;
using GAsk.Library.Utils;
using GAsk.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.ViewComponents
{
    /// <summary>
    /// 话题导航组件
    /// </summary>
    public class TopicNavbarViewComponent : ViewComponent
    {
        private readonly TopicService topicService;
        public TopicNavbarViewComponent(TopicService topicService)
        {
            this.topicService = topicService ?? throw new ArgumentNullException(nameof(topicService));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Topic> topics = new List<Topic>();
            Topic defaultTopic = new Topic { Id = Guid.Empty, Name = "最新" };
            topics.Add(defaultTopic);
            topics.AddRange(await this.topicService.GetAllAsync(true, Library.Enums.SearchType.Visible));
            QueryWrapper query = new QueryWrapper(this.HttpContext);
            string id = query.GetValue("topic");
            Topic selectedTopic = topics.Where(p => p.Id.ToString() == id).FirstOrDefault();
            if (selectedTopic == null)
            {
                selectedTopic = defaultTopic;
            }
            TopicNavbarComponentModel model = new TopicNavbarComponentModel(topics, selectedTopic, HttpContext);
            return View(model);
        }
    }
}