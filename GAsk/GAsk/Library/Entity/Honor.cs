using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Ado;

namespace GAsk.Library.Entity
{
    /// <summary>
    /// 头衔
    /// </summary>
    public class Honor : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}