// -----------------------------------------------------------------------
//  <copyright file="UserExtend.cs" company="OSharp开源团队">
//      Copyright (c) 2015 OSharp. All rights reserved.
//  </copyright>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2015-01-08 0:20</last-date>
// -----------------------------------------------------------------------

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using OSharp.Core.Data;
using System;

namespace TG.UBP.Core.Entity.BaseManage.Identity
{
    /// <summary>
    /// 实体类——用户扩展信息，保存了用户的身份信息（组织、岗位、职位等信息），后续需要考虑如何和ERP的用户信息做接口或干脆直接引用ERP的用户信息。
    /// </summary>
    [Description("认证-用户扩展信息，保存了用户的身份信息")]
    public class UserExtend : IEntity<int>
    {
        /// <summary>
        /// 获取或设置 注册IP地址
        /// </summary>
        [StringLength(18)]
        public string RegistedIp { get; set; }

        /// <summary>
        /// 获取或设置 用户信息
        /// </summary>
        [Required]
        public virtual User User { get; set; }

        /// <summary>
        /// 获取或设置 实体唯一标识，主键
        /// </summary>
        [Key]
        public int Id { get; set; }


        #region 根据力软和Ymnets系统增加的字段
        /*
        /// <summary>
        /// 真实姓名
        /// </summary>		
        [StringLength(50)]
        public string RealName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>		
        public int? Gender { get; set; }
        /// <summary>
        /// 生日
        /// </summary>		
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// QQ号
        /// </summary>		
        [StringLength(50)]
        public string QQ { get; set; }
        /// <summary>
        /// 微信号
        /// </summary>		
        [StringLength(50)]
        public string WeChat { get; set; }
        /// <summary>
        /// MSN
        /// </summary>		
        [StringLength(50)]
        public string MSN { get; set; }
        /// <summary>
        /// 主管主键
        /// </summary>		
        public int? ManagerId { get; set; }
        /// <summary>
        /// 主管
        /// </summary>		
        [StringLength(50)]
        public string Manager { get; set; }
        /// <summary>
        /// 机构主键
        /// </summary>		
        public int? OrganizeId { get; set; }
        /// <summary>
        /// 部门主键
        /// </summary>		
        public string DepartmentId { get; set; }
        /// <summary>
        /// 角色主键
        /// </summary>		
        public string RoleId { get; set; }
        /// <summary>
        /// 岗位主键
        /// </summary>		
        public string DutyId { get; set; }
        /// <summary>
        /// 岗位名称
        /// </summary>		
        public string DutyName { get; set; }
        /// <summary>
        /// 职位主键
        /// </summary>		
        public string PostId { get; set; }
        /// <summary>
        /// 职位名称
        /// </summary>		
        public string PostName { get; set; }
        /// <summary>
        /// 工作组主键
        /// </summary>		
        public string WorkGroupId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>		
        public string Description { get; set; }
        */
        #endregion
    }
}