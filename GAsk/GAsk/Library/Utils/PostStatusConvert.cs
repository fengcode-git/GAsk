using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Ado;
using GAsk.Library.Enums;

namespace GAsk.Library.Utils
{
    public class PostStatusConvert : BaseValueConvert
    {
        public override object Read(object dbValue)
        {
            return (PostStatus)dbValue;
        }

        public override object Write(object propertyValue)
        {
            return (int)propertyValue;
        }
    }
}
