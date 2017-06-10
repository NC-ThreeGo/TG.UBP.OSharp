using OSharp.Core.Security;
using OSharp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.Security
{
    public class FunctionConfiguration_Oracle : EntityConfigurationBase<Function, Guid>
    {
        public FunctionConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            Property(t => t.Id).HasColumnName("ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            //Property(t => t.Name).HasColumnName("NAME");
            //Property(t => t.Area).HasColumnName("AREA");
            //Property(t => t.Controller).HasColumnName("CONTROLLER");
            //Property(t => t.Action).HasColumnName("ACTION");
            //Property(t => t.FunctionType).HasColumnName("FUNCTIONTYPE");
            //Property(t => t.IsTypeChanged).HasColumnName("ISTYPECHANGED");
            //Property(t => t.OperateLogEnabled).HasColumnName("OPERATELOGENABLED");
            //Property(t => t.DataLogEnabled).HasColumnName("DATALOGENABLED");
            //Property(t => t.CacheExpirationSeconds).HasColumnName("CACHEEXPIRATIONSECONDS");
            //Property(t => t.IsCacheSliding).HasColumnName("ISCACHESLIDING");
            //Property(t => t.PlatformToken).HasColumnName("PLATFORMTOKEN");
            //Property(t => t.Url).HasColumnName("URL");
            //Property(t => t.IsController).HasColumnName("ISCONTROLLER");
            //Property(t => t.IsAjax).HasColumnName("ISAJAX");
            //Property(t => t.IsChild).HasColumnName("ISCHILD");
            //Property(t => t.IsLocked).HasColumnName("ISLOCKED");
            //Property(t => t.IsCustom).HasColumnName("ISCUSTOM");
            //Property(t => t.IsDeleted).HasColumnName("ISDELETED");

            //ToTable("FUNCTIONS");
        }
    }
}
