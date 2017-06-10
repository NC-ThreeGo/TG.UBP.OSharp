using OSharp.Core.Security;
using OSharp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.Security
{
    public class EntityInfoConfiguration_Oracle : EntityConfigurationBase<EntityInfo, Guid>
    {
        public EntityInfoConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            Property(t => t.Id).HasColumnName("ID")
                                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            //Property(t => t.ClassName).HasColumnName("CLASSNAME")
            //    .HasMaxLength(2000);
            //Property(t => t.Name).HasColumnName("NAME")
            //    .HasMaxLength(2000);
            //Property(t => t.DataLogEnabled).HasColumnName("DATALOGENABLED");
            //Property(t => t.PropertyNamesJson).HasColumnName("PROPERTYNAMESJSON")
            //    .HasMaxLength(2000);
            //Property(t => t.IsDeleted).HasColumnName("ISDELETED");

            //ToTable("ENTITYINFOS");
        }
    }
}
