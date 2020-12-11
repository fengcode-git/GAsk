using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Areas.Admin.Models;
using GAsk.Library.BBL;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.Areas.Admin.ViewComponents
{
    /// <summary>
    /// 统计视图组件
    /// </summary>
    public class StatisticsViewComponent: ViewComponent
    {
        private readonly StatisticsService statisticsService;

        public StatisticsViewComponent(StatisticsService statisticsService)
        {
            this.statisticsService = statisticsService ?? throw new ArgumentNullException(nameof(statisticsService));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            StatisticsComponentModel model = new StatisticsComponentModel()
            {
                ArticleCount = await this.statisticsService.GetArticleCountAsync(),
                CommentCount = await this.statisticsService.GetCommentCountAsync(),
                QuestionCount = await this.statisticsService.GetQuestionCountAsync(),
                UserCount = await this.statisticsService.GetUserCount()
            };
            return View(model);
        }
    }
}
