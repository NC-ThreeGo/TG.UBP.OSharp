using OSharp.Data.Entity;
using TG.UBP.Core.Entity.BaseManage.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.OAuth
{
    public class ClientRefreshTokenConfiguration_Oracle : EntityConfigurationBase<OAuthClientRefreshToken, Guid>
    {
        public ClientRefreshTokenConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            Property(t => t.Id).HasColumnName("ID")
                                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            //Property(t => t.Value).HasColumnName("TITLE");
            //Property(t => t.ProtectedTicket).HasColumnName("PROTECTEDTICKET");
            //Property(t => t.IssuedUtc).HasColumnName("ISSUEDUTC");
            //Property(t => t.ExpiresUtc).HasColumnName("EXPIRESUTC");

            //ToTable("OAUTHCLIENTREFRESHTOKENS");
        }
    }
}
