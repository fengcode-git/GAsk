using System;
using FengCode.Libs.Ado;
using GAsk.Library.Enums;
using GAsk.Library.Utils;

namespace GAsk.Library.Entity
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Role : BaseEntity
    {
        public Guid Id { get; set; }

        [Index]
        public string Name { get; set; }

        [Index]
        public RoleType RoleType { get; set; }
    }
}