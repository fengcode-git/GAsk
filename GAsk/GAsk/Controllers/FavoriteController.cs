using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.BBL;
using GAsk.Library.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly FavoriteService favoriteService;

        public FavoriteController(FavoriteService favoriteService)
        {
            this.favoriteService = favoriteService ?? throw new ArgumentNullException(nameof(favoriteService));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(Guid postId)
        {
            try
            {
                await this.favoriteService.InsertFavoriteAsync(postId);
                return Json(AjaxResult.CreateDefaultSuccess());
            }
            catch (Exception ex)
            {
                return Json(AjaxResult.CreateByMessage(ex.Message, false));
            }
        }
    }
}
