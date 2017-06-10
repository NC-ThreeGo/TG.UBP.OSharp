using OSharp.Core.Logging;
using OSharp.Data.Entity;
using OSharp.Data.Entity.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.Logging
{
    public class OperateLogConfiguration_Oracle : EntityConfigurationBase<OperateLog, int>
    {
        /// <summary>
        /// 初始化一个<see cref="OperateLogConfiguration_Oracle"/>类型的新实例
        /// </summary>
        public OperateLogConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            //Property(t => t.Id).HasColumnName("ID");
            //Property(t => t.FunctionName).HasColumnName("FUNCTIONNAME");
            //Property(t => t.Operator.UserId).HasColumnName("OPERATOR_USERID");
            //Property(t => t.Operator.Name).HasColumnName("OPERATOR_NAME");
            //Property(t => t.Operator.NickName).HasColumnName("OPERATOR_NICKNAME");
            //Property(t => t.Operator.Ip).HasColumnName("OPERATOR_IP");
            //Property(t => t.CreatedTime).HasColumnName("CREATEDTIME");

            //ToTable("OPERATELOGS");
        }

        /// <summary>
        /// 获取 相关上下文类型，如为null，将使用默认上下文，否则使用指定的上下文类型
        /// </summary>
        public override Type DbContextType
        {
            get { return typeof(LoggingDbContext); }
        }
    }
}
