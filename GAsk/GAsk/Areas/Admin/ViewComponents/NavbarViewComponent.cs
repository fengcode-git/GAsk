using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Areas.Admin.Models;
using GAsk.Library.DAL;
using GAsk.Library.Entity;
using GAsk.Library.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.Areas.Admin.ViewComponents
{
    public class NavbarViewComponent: ViewComponent
    {
        private readonly DbFactory dbFactory;

        public NavbarViewComponent(DbFactory dbFactory)
        {
            this.dbFactory = dbFactory ?? throw new ArgumentNullException(nameof(dbFactory));
        }

        public IViewComponentResult Invoke()
        {
            this.ViewData["id"] = this.HttpContext.User.GetUserId();
            this.ViewData["NickName"] = this.HttpContext.User.GetUserName();
            return View();
        }
    }
}
