using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Paging;
using GAsk.Library.BBL;
using GAsk.Library.Entity;
using GAsk.Library.Enums;
using GAsk.Models;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.Controllers
{
    public class TopicController : Controller
    {
        private readonly TopicService topicService;
        private readonly PostService postService;

        public TopicController(TopicService topicService, PostService postService)
        {
            this.topicService = topicService ?? throw new ArgumentNullException(nameof(topicService));
            this.postService = postService ?? throw new ArgumentNullException(nameof(postService));
        }

        public async Task<IActionResult> Details(Guid id, FilterType filter = FilterType.New, int page = 1)
        {
            Topic topic = await topicService.GetByIdAsync(id);
            if (topic == null || topic.IsHide)
            {
                return NotFound();
            }
            if (page <= 0)
            {
                return NotFound();
            }
            PagingResult<PostView> result = await this.postService.GetPagingResultAsync(id, PostResultType.All, page, filter);
            if (result.PageCount > 1 && page > result.PageCount)
            {
                return NotFound();
            }
            TopicDetailsModel model = new TopicDetailsModel
            {
                Topic = topic,
                PagingResult = result
            };
            return View(model);
        }
    }
}