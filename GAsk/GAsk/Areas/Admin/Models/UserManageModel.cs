using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Paging;
using FengCode.Libs.Utils.Reflection;
using GAsk.Library.Entity;
using GAsk.Library.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GAsk.Areas.Admin.Models
{
    /// <summary>
    /// 用户管理
    /// </summary>
    public class UserManageModel
    {
        public PagingResult<PersonView> PagingResult { get; set; }
        public string Search { get; set; }
        public RoleFilterType RoleFilter { get; set; }
        public List<SelectListItem> SelectListItems { get; }

        public UserManageModel(PagingResult<PersonView> pagingResult, string search, RoleFilterType roleFilter)
        {
            PagingResult = pagingResult;
            Search = search;
            RoleFilter = roleFilter;
            this.SelectListItems = EnumUitls.ToSelectListItems<RoleFilterType>(false);
        }
    }
}
