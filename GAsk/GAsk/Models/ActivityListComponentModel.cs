using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.Entity;

namespace GAsk.Models
{
    /// <summary>
    /// 活动列表组件模型
    /// </summary>
    public class ActivityListComponentModel
    {
        public List<ActivityView> ActivityViews { get; set; } = new List<ActivityView>();
    }
}
