using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.BBL;
using GAsk.Library.Setting;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.ViewComponents
{
    /// <summary>
    /// 页脚版权组件
    /// </summary>
    public class CopyrightViewComponent: ViewComponent
    {
        private readonly ConfigService configService;

        public CopyrightViewComponent(ConfigService configService)
        {
            this.configService = configService ?? throw new ArgumentNullException(nameof(configService));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HomeConfig config =  await this.configService.GetConfigAsync<HomeConfig>();
            this.ViewData["_SiteFooter"] = config.SiteFooter;
            return View();
        }
    }
}
