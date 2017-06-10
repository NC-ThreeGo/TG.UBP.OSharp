using OSharp.Data.Entity;
using TG.UBP.Core.Entity.BaseManage.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.OAuth
{
    public class ClientConfiguration_Oracle : EntityConfigurationBase<OAuthClient, int>
    {
        public ClientConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            //Property(t => t.Id).HasColumnName("ID");
            //Property(t => t.Name).HasColumnName("NAME");
            //Property(t => t.OAuthClientType).HasColumnName("OAUTHCLIENTTYPE");
            //Property(t => t.ClientId).HasColumnName("CLIENTID");
            //Property(t => t.Url).HasColumnName("URL");
            //Property(t => t.LogoUrl).HasColumnName("LOGOURL");
            //Property(t => t.RedirectUrl).HasColumnName("REDIRECTURL");
            //Property(t => t.RequireConsent).HasColumnName("REQUIRECONSENT");
            //Property(t => t.AllowClientCredentialsOnly).HasColumnName("ALLOWCLIENTCREDENTIALSONLY");
            //Property(t => t.AllowRememberConsent).HasColumnName("ALLOWREMEMBERCONSENT");
            //Property(t => t.IsLocked).HasColumnName("ISLOCKED");
            //Property(t => t.CreatedTime).HasColumnName("CREATEDTIME");

            //ToTable("OAUTHCLIENTS");
        }
    }
}
