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
    public class DataLogConfiguration_Oracle : EntityConfigurationBase<DataLog, int>
    {
        /// <summary>
        /// 初始化一个<see cref="DataLogConfiguration_Oracle"/>类型的新实例
        /// </summary>
        public DataLogConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            //Property(t => t.Id).HasColumnName("ID");
            //Property(t => t.EntityName).HasColumnName("ENTITYNAME");
            //Property(t => t.Name).HasColumnName("NAME");
            //Property(t => t.EntityKey).HasColumnName("ENTITYKEY");
            //Property(t => t.OperateType).HasColumnName("OPERATETYPE");

            HasOptional(m => m.OperateLog).WithMany(n => n.DataLogs)
                //.Map(p =>
                //    {
                //        p.MapKey("OPERATELOG_ID");
                //        //p.ToTable("OPERATELOGS");
                //    })
                .WillCascadeOnDelete(true);

            //ToTable("DATALOGS");
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
