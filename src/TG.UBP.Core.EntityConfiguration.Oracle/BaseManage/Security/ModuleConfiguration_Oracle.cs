using OSharp.Data.Entity;
using TG.UBP.Core.Entity.BaseManage.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.Security
{
    public class ModuleConfiguration_Oracle : EntityConfigurationBase<Module, int>
    {
        public ModuleConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            //Property(t => t.Id).HasColumnName("ID");
            //Property(t => t.Name).HasColumnName("NAME");
            //Property(t => t.Remark).HasColumnName("REMARK");
            //Property(t => t.OrderCode).HasColumnName("ORDERCODE");
            //Property(t => t.TreePathString).HasColumnName("TREEPATHSTRING");

            //HasMany(m => m.SubModules).WithOptional(n => n.Parent).Map(p =>
            //    {
            //        p.MapKey("PARENT_ID");
            //    });

            //ToTable("MODULES");

            //HasMany(m => m.Functions).WithMany().Map(p =>
            //    {
            //        p.MapLeftKey("MODULE_ID");
            //        p.MapRightKey("FUNCTION_ID");
            //        p.ToTable("MODULEFUNCTIONS");
            //    });

            //HasMany(m => m.Roles).WithMany().Map(p =>
            //{
            //    p.MapLeftKey("MODULE_ID");
            //    p.MapRightKey("ROLE_ID");
            //    p.ToTable("MODULEROLES");
            //});

            //HasMany(m => m.Users).WithMany().Map(p =>
            //{
            //    p.MapLeftKey("MODULE_ID");
            //    p.MapRightKey("USER_ID");
            //    p.ToTable("MODULEUSERS");
            //});

            HasMany(m => m.SubModules).WithOptional(n => n.Parent);
            HasMany(m => m.Functions).WithMany();
            HasMany(m => m.Roles).WithMany();
            HasMany(m => m.Users).WithMany();
        }
    }
}
