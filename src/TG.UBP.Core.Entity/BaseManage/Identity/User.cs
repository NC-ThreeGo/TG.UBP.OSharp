// -----------------------------------------------------------------------
//  <copyright file="Member.cs" company="OSharp开源团队">
//      Copyright (c) 2015 OSharp. All rights reserved.
//  </copyright>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2015-01-07 23:33</last-date>
// -----------------------------------------------------------------------

using System.ComponentModel;

using OSharp.Core.Identity.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace TG.UBP.Core.Entity.BaseManage.Identity
{
    /// <summary>
    /// 实体类——用户信息
    /// </summary>
    [Description("认证-用户信息")]
    public class User : UserBase<int>
    {
        /// <summary>
        /// 获取或设置 是否冻结
        /// </summary>
        public bool IsLocked { get; set; }

        ///// <summary>
        ///// 获取或设置 注册IP地址
        ///// </summary>
        //[StringLength(18)]
        //public string RegistedIp { get; set; }

        /// <summary>
        /// 获取或设置 用户扩展信息
        /// </summary>
        public virtual UserExtend Extend { get; set; }


        #region 根据力软和Ymnets系统增加的字段
        /*
        /// <summary>
        /// 头像/照片
        /// </summary>
        [StringLength(200)]
        public string Photo { get; set; }
        /// <summary>
        /// 安全级别
        /// </summary>		
        public int? SecurityLevel { get; set; }
        /// <summary>
        /// 在线状态
        /// </summary>		
        public bool UserOnLine { get; set; }
        /// <summary>
        /// 单点登录标识
        /// </summary>		
        public int? OpenId { get; set; }
        /// <summary>
        /// 密码提示问题
        /// </summary>		
        [StringLength(50)]
        public string Question { get; set; }
        /// <summary>
        /// 密码提示答案
        /// </summary>		
        [StringLength(50)]
        public string AnswerQuestion { get; set; }
        /// <summary>
        /// 允许多用户同时登录
        /// </summary>		
        public bool CheckOnLine { get; set; }
        /// <summary>
        /// 允许登录时间开始
        /// </summary>		
        public DateTime? AllowStartTime { get; set; }
        /// <summary>
        /// 允许登录时间结束
        /// </summary>		
        public DateTime? AllowEndTime { get; set; }
        /// <summary>
        /// 暂停用户开始日期
        /// </summary>		
        public DateTime? LockStartDate { get; set; }
        /// <summary>
        /// 暂停用户结束日期
        /// </summary>		
        public DateTime? LockEndDate { get; set; }
        /// <summary>
        /// 第一次访问时间
        /// </summary>		
        public DateTime? FirstVisit { get; set; }
        /// <summary>
        /// 上一次访问时间
        /// </summary>		
        public DateTime? PreviousVisit { get; set; }
        /// <summary>
        /// 最后访问时间
        /// </summary>		
        public DateTime? LastVisit { get; set; }
        /// <summary>
        /// 登录次数
        /// </summary>		
        public int? LogOnCount { get; set; }
        /// <summary>
        /// 排序码
        /// </summary>		
        public int? SortCode { get; set; }
        /// <summary>
        /// 删除标记
        /// </summary>		
        public int? DeleteMark { get; set; }
        */
        #endregion
    }
}