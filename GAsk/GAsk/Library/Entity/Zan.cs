using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Ado;
using GAsk.Library.Enums;

namespace GAsk.Library.Entity
{
    /// <summary>
    /// 点赞
    /// </summary>
    public class Zan : BaseEntity
    {
        public Guid Id { get; set; }
        /// <summary>
        /// 点赞类型
        /// </summary>
        public ZanType ZanType { get; set; }
        /// <summary>
        /// 会话ID
        /// </summary>
        [Index]
        public string SessionId { get; set; }
        [Index]
        public Guid? PersonId { get; set; }
        [Index]
        public Guid? PostId { get; set; }
        [Index]
        public Guid? CommentId { get; set; }
        [Index]
        public DateTime DoTime { get; set; }
    }
}