using OSharp.Data.Entity;
using TG.UBP.Core.Entity.BaseManage.Identity;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.Identity
{
    public class UserLoginConfiguration_Oracle : EntityConfigurationBase<UserLogin, int>
    {
        public UserLoginConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            //Property(t => t.Id).HasColumnName("ID");
            //Property(t => t.LoginProvider).HasColumnName("LOGINPROVIDER");
            //Property(t => t.ProviderKey).HasColumnName("PROVIDERKEY");
            //Property(t => t.CreatedTime).HasColumnName("CREATEDTIME");

            HasRequired(m => m.User).WithMany();
            //HasRequired(m => m.User).WithMany().Map(p =>
            //    {
            //        p.MapKey("USER_ID");
            //        //p.ToTable("USERS");
            //    });

            //ToTable("USERLOGINS");
        }
    }
}
