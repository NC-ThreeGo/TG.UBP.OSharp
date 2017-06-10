using OSharp.Data.Entity;
using TG.UBP.Core.Entity.BaseManage.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.Security
{
    public class EntityRoleMapConfiguration_Oracle : EntityConfigurationBase<EntityRoleMap, int>
    {
        public EntityRoleMapConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            //Property(t => t.Id).HasColumnName("ID");
            //Property(t => t.FilterGroupJson).HasColumnName("FILTERGROUPJSON");
            //Property(t => t.IsLocked).HasColumnName("ISLOCKED");
            //Property(t => t.CreatedTime).HasColumnName("CREATEDTIME");

            //ToTable("ENTITYROLEMAPS");
        }
    }
}
