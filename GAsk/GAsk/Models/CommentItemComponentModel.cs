using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using FengCode.Libs.Utils.Text;
using FengCode.Libs.Utils.Time;
using GAsk.Library.BBL;
using GAsk.Library.DAL;
using GAsk.Library.Entity;
using Microsoft.AspNetCore.Http;

namespace GAsk.Models
{
    /// <summary>
    /// 评论元素模型
    /// </summary>
    public class CommentItemComponentModel
    {
        /// <summary>
        /// 浏览者(可能为空)
        /// </summary>
        public PersonView LoginPerson { get; set; }
        /// <summary>
        /// 评论
        /// </summary>
        public CommentView CommentView { get; set; }

        /// <summary>
        /// 是否已赞
        /// </summary>
        public bool IsLike { get; set; }

        private readonly DbFactory dbFactory;

        public CommentItemComponentModel(PersonView loginPerson, CommentView commentView, DbFactory dbFactory,bool isLike)
        {
            LoginPerson = loginPerson;
            CommentView = commentView;
            this.dbFactory = dbFactory;
            this.IsLike = isLike;
        }

        public string GetTimeString()
        {
            if (CommentView.ModifyTime != null)
            {
                return "修改于：" + DateTimeHelper.DateStringFromNow(CommentView.ModifyTime.Value);
            }
            else
            {
                return "撰写于：" + DateTimeHelper.DateStringFromNow(this.CommentView.CreateTime);
            }
        }
        /// <summary>
        /// 获取父评论的引用
        /// </summary>
        public async Task<string> GetQuoteAsync()
        {
            if (this.CommentView.ParentId == null)
            {
                return "";
            }
            else
            {
                using (var work = this.dbFactory.StartWork())
                {
                    CommentView parent = await work.CommentView.SingleByIdAsync(this.CommentView.ParentId.Value);
                    if (parent == null || parent.IsDelete)
                    {
                        return $"<div class=\"alert alert-secondary mt-2 mb-0\">该评论已被删除</div>";
                    }
                    else
                    {
                        return $"<div class=\"alert alert-secondary mt-2 mb-0\"> @{HttpUtility.HtmlEncode(parent.NickName)} {StringHelper.StringTruncat(parent.TextContent,20)}</div>";
                    }
                }
            }            
        }
    }
}