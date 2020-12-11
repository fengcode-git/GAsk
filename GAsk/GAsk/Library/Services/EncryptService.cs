using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.Utils;

namespace GAsk.Library.Services
{
    /// <summary>
    /// 加密服务
    /// </summary>
    public class EncryptService
    {
        /// <summary>
        /// 生成密码哈希值
        /// </summary>
        public string PasswordHash(string password)
        {
            return PasswordEncryptor.Hash(password);
        }

    }
}
