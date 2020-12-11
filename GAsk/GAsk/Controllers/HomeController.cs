using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GAsk.Models;
using GAsk.Library.DAL;
using FengCode.Libs.Utils.Text;
using FengCode.Libs.Image;
using GAsk.Library.Extensions;
using GAsk.Library.Utils;
using Microsoft.AspNetCore.Http;
using GAsk.Library.Services;
using Microsoft.AspNetCore.Authorization;
using GAsk.Library.BBL;
using GAsk.Library.Entity;
using FengCode.Libs.Utils.Paging;
using GAsk.Library.Enums;

namespace GAsk.Controllers
{
    [Route("[action]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly UploadService uploadService;
        private readonly PostService postService;
        private readonly PersonService personService;
        public HomeController(ILogger<HomeController> logger, UploadService upload, PostService postService, PersonService personService)
        {
            this.logger = logger;
            this.uploadService = upload;
            this.postService = postService;
            this.personService = personService;
        }

        [Route("/")]
        public async Task<IActionResult> Index(Guid topic, FilterType filter = FilterType.New, int page = 1)
        {
            if (page < 1)
            {
                return NotFound();
            }
            PagingResult<PostView> postViews = await postService.SearchAsync(topic, filter, "", page);
            if (postViews.PageCount > 1 && page > postViews.PageCount)
            {
                return NotFound();
            }
            PersonView person = await this.personService.GetCurrentPersonViewAsync();
            HomeIndexModel model = new HomeIndexModel
            {
                PostViews = postViews,
                LoginPerson = person
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> CodeImage()
        {
            string code = RandomHelper.GetVerifyCode();
            ImageWrapper image = ImageWrapper.CreateByVerifyCode(code);
            await HttpContext.Session.SetVerifyCodeAsync(code);
            return new ImageStreamResult(image.ImageBytes);
        }



        /// <summary>
        /// 上传图片，限制为1M
        /// </summary>
        [HttpPost]
        [Authorize]
        [RequestSizeLimit(1024 * 1024 * 1)]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            try
            {
                UploadInfo info = await this.uploadService.UploadImageAsync(file, false);
                return this.Json(AjaxResult.CreateByContext(info.UrlPath));
            }
            catch (Exception e)
            {
                return this.Json(new { uploaded = 0, error = new { message = e.Message } });
            }
        }

        public IActionResult CreatePost()
        {
            return View();
        }
    }
}
