using OSharp.Data.Entity;
using TG.UBP.Core.Entity.BaseManage.Identity;
using System;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.Identity
{
    public class UserRoleMapConfiguration_Oracle : EntityConfigurationBase<UserRoleMap, Int32>
    {
        public UserRoleMapConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            //Property(t => t.Id).HasColumnName("ID");
            //Property(t => t.IsLocked).HasColumnName("NAME");
            //Property(t => t.CreatedTime).HasColumnName("CREATEDTIME");
            //Property(t => t.BeginTime).HasColumnName("BEGINTIME");
            //Property(t => t.EndTime).HasColumnName("ENDTIME");

            //HasRequired(m => m.User).WithMany().Map(p =>
            //    {
            //        p.MapKey("USER_ID");
            //        //p.ToTable("USERS");
            //    });

            //HasRequired(m => m.Role).WithMany().Map(p =>
            //{
            //    p.MapKey("ROLE_ID");
            //    //p.ToTable("ROLES");
            //});

            //ToTable("USERROLEMAPS");

            HasRequired(m => m.User).WithMany();
            HasRequired(m => m.Role).WithMany();
        }
    }
}
