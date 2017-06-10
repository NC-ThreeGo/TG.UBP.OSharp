using OSharp.Data.Entity;
using TG.UBP.Core.Entity.BaseManage.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.Identity
{
    public class UserClaimConfiguration_Oracle : EntityConfigurationBase<UserClaim, int>
    {
        public UserClaimConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            //Property(t => t.Id).HasColumnName("ID");
            //Property(t => t.ClaimType).HasColumnName("CLAIMTYPE");
            //Property(t => t.ClaimValue).HasColumnName("CLAIMVALUE");
            //Property(t => t.CreatedTime).HasColumnName("CREATEDTIME");

            HasRequired(m => m.User).WithMany();
            //HasRequired(m => m.User).WithMany().Map(p =>
            //{
            //    p.MapKey("USER_ID");
            //});

            //ToTable("USERCLAIMS");
        }
    }
}
