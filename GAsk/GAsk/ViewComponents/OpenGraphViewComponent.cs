using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.BBL;
using GAsk.Library.Setting;
using GAsk.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.ViewComponents
{
    /// <summary>
    /// OG协议视图组件
    /// </summary>
    public class OpenGraphViewComponent : ViewComponent
    {
        private readonly ConfigService configService;

        public OpenGraphViewComponent(ConfigService configService)
        {
            this.configService = configService ?? throw new ArgumentNullException(nameof(configService));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HomeConfig config = await this.configService.GetHomeConfigAsync();
            string url = this.HttpContext.Request.GetEncodedUrl();
            OpenGraphComponentModel model = new OpenGraphComponentModel()
            {
                SiteName = config.SiteName,
                Url = url,
                IsHome = this.HttpContext.Request.Path == "/",
                HomeDescription = config.SeoDescription
            };
            return View(model);
        }
    }
}


