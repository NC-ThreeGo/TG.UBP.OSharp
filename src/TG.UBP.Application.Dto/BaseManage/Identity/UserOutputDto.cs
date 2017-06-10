using OSharp.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Application.Dto.BaseManage.Identity
{
    public class UserOutputDto : IOutputDto
    {
        /// <summary>
        /// 获取或设置 主键，唯一标识
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Unique username
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 获取或设置 用户昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 获取或设置 电子邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 获取或设置 电子邮箱是否验证
        /// </summary>
        public bool EmailConfirmed { get; set; }

        /// <summary>
        /// 获取或设置 手机号码
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置 手机号码是否验证
        /// </summary>
        public bool PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// 获取或设置 注册IP
        /// </summary>
        public string RegistedIp { get; set; }

        /// <summary>
        /// 获取或设置 是否锁定
        /// </summary>
        public bool IsLocked { get; set; }
    }
}
