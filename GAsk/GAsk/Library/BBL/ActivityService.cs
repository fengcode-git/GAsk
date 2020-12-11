using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Paging;
using GAsk.Library.DAL;
using GAsk.Library.Entity;
using GAsk.Library.Setting;

namespace GAsk.Library.BBL
{
    /// <summary>
    /// 活动服务
    /// </summary>
    public class ActivityService
    {
        private readonly DbFactory dbFactory;

        public ActivityService(DbFactory dbFactory)
        {
            this.dbFactory = dbFactory ?? throw new ArgumentNullException(nameof(dbFactory));
        }

        /// <summary>
        /// 获取指定用户的活动
        /// </summary>
        public async Task<PagingResult<ActivityView>> GetPagingResultsAsync(Person person, int page)
        {
            using (var work = this.dbFactory.StartWork())
            {
                PageConfig pageConfig = await work.Config.GetConfigAsync<PageConfig>();
                return await work.ActivityView.GetPagingResultAsync(person, page, pageConfig.PageSize);
            }
        }
    }
}
