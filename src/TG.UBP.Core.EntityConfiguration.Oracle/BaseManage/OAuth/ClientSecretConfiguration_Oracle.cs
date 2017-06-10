using OSharp.Data.Entity;
using TG.UBP.Core.Entity.BaseManage.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.OAuth
{
    public class ClientSecretConfiguration_Oracle : EntityConfigurationBase<OAuthClientSecret, int>
    {
        public ClientSecretConfiguration_Oracle()
        {
            //将实体映射到Oracle数据库
            //Property(t => t.Id).HasColumnName("ID");
            //Property(t => t.Value).HasColumnName("VALUE");
            //Property(t => t.Type).HasColumnName("TYPE");
            //Property(t => t.Remark).HasColumnName("REMARK");
            //Property(t => t.IsLocked).HasColumnName("ISLOCKED");
            //Property(t => t.BeginTime).HasColumnName("BEGINTIME");
            //Property(t => t.EndTime).HasColumnName("ENDTIME");

            //HasRequired(m => m.Client).WithMany(n => n.ClientSecrets).Map(p =>
            //    {
            //        p.MapKey("CLIENT_ID");
            //        //p.ToTable("OAUTHCLIENTS");
            //    })
            //    .WillCascadeOnDelete(true);

            //ToTable("OAUTHCLIENTSECRETS");

            HasRequired(m => m.Client).WithMany(n => n.ClientSecrets);
        }
    }
}
