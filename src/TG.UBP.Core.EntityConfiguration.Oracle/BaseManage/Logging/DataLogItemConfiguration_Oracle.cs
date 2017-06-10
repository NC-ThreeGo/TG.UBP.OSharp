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
    public class DataLogItemConfiguration_Oracle : EntityConfigurationBase<DataLogItem, Guid>
    {
        /// <summary>
        /// 初始化一个<see cref="DataLogItemConfiguration_Oracle"/>类型的新实例
        /// </summary>
        public DataLogItemConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            Property(t => t.Id).HasColumnName("ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            //Property(t => t.Field).HasColumnName("FIELD");
            //Property(t => t.FieldName).HasColumnName("FIELDNAME");
            //Property(t => t.OriginalValue).HasColumnName("ORIGINALVALUE");
            //Property(t => t.NewValue).HasColumnName("NEWVALUE");
            //Property(t => t.DataType).HasColumnName("DATATYPE");

            HasRequired(m => m.DataLog).WithMany(n => n.LogItems)
                //.Map(p =>
                //{
                //    p.MapKey("DATALOG_ID");
                //})
                .WillCascadeOnDelete(true);

            //ToTable("DATALOGITEMS");
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
