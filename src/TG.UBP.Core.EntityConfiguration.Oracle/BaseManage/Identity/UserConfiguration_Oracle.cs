using TG.UBP.Core.Entity.BaseManage.Identity;
using System;
using OSharp.Data.Entity;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.Identity
{
    public class UserConfiguration_Oracle : EntityConfigurationBase<User, Int32>
    {
        public UserConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            //Property(t => t.Id).HasColumnName("ID");
            //Property(t => t.IsLocked).HasColumnName("ISLOCKED");
            //Property(t => t.UserName).HasColumnName("USERNAME");
            //Property(t => t.NickName).HasColumnName("NICKNAME");
            //Property(t => t.Email).HasColumnName("EMAIL");
            //Property(t => t.EmailConfirmed).HasColumnName("EMAILCONFIRMED");
            //Property(t => t.PasswordHash).HasColumnName("PASSWORDHASH");
            //Property(t => t.SecurityStmp).HasColumnName("SECURITYSTMP");
            //Property(t => t.PhoneNumber).HasColumnName("PHONENUMBER");
            //Property(t => t.PhoneNumberConfirmed).HasColumnName("PHONENUMBERCONFIRMED");
            //Property(t => t.TwoFactorEnabled).HasColumnName("TWOFACTORENABLED");
            //Property(t => t.LockoutEnabled).HasColumnName("LOCKOUTENABLED");
            //Property(t => t.LockoutEndDateUtc).HasColumnName("LOCKOUTENDDATEUTC");
            //Property(t => t.AccessFailedCount).HasColumnName("ACCESSFAILEDCOUNT");
            //Property(t => t.CreatedTime).HasColumnName("CREATEDTIME");

            //ToTable("USERS");
        }
    }
}
