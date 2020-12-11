using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.BBL;
using GAsk.Library.Info;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.Areas.Admin.Models
{
    /// <summary>
    /// 注册趋势图表组件模型
    /// </summary>
    public class RegisterChartComponentModel
    {
        public List<PersonRegisterInfo> Data { get; set; } = new List<PersonRegisterInfo>();
    }
}
