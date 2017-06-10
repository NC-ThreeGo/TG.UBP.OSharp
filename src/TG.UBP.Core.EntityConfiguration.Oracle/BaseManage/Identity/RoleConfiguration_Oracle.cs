using OSharp.Data.Entity;
using TG.UBP.Core.Entity.BaseManage.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.Identity
{
    public class RoleConfiguration_Oracle : EntityConfigurationBase<Role, Int32>
    {
        /// <summary>
        /// 初始化一个<see cref="RoleConfiguration"/>类型的新实例
        /// </summary>
        public RoleConfiguration_Oracle()
        {
            RoleConfigurationAppend();
        }

        void RoleConfigurationAppend()
        {
            //将实体映射到Oracle数据库
            //Property(t => t.Id).HasColumnName("ID");
            //Property(t => t.Name).HasColumnName("NAME");
            //Property(t => t.Remark).HasColumnName("REMARK");
            //Property(t => t.IsLocked).HasColumnName("ISLOCKED");
            //Property(t => t.IsAdmin).HasColumnName("ISADMIN");
            //Property(t => t.IsDefault).HasColumnName("ISDEFAULT");
            //Property(t => t.IsSystem).HasColumnName("ISSYSTEM");
            //Property(t => t.CreatedTime).HasColumnName("CREATEDTIME");

            HasOptional(m => m.Organization).WithMany(n => n.Roles);
            //HasOptional(m => m.Organization).WithMany(n => n.Roles)
            //    .Map(p =>
            //    {
            //        p.MapKey("ORGANIZATION_ID");
            //        //p.ToTable("ROLES");
            //    });

            //ToTable("ROLES");
        }
    }
}
