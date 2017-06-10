using OSharp.Data.Entity;
using TG.UBP.Core.Entity.BaseManage.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Core.EntityConfiguration.Oracle.BaseManage.Identity
{
    public partial class OrganizationConfiguration_Oracle : EntityConfigurationBase<Organization, Int32>
    {
        /// <summary>
        /// 初始化一个<see cref="OrganizationConfiguration"/>类型的新实例
        /// </summary>
        public OrganizationConfiguration_Oracle()
        {
            OrganizationConfigurationAppend();
        }

        /// <summary>
        /// 获取 相关上下文类型
        /// </summary>
        public override Type DbContextType
        {
            get { return typeof(DefaultDbContext); }
        }

        void OrganizationConfigurationAppend()
        {
            //将实体映射到Oracle数据库
            //Property(t => t.Id).HasColumnName("ID");
            //Property(t => t.Name).HasColumnName("NAME");
            //Property(t => t.Remark).HasColumnName("REMARK");
            //Property(t => t.SortCode).HasColumnName("SORTCODE");
            //Property(t => t.TreePath).HasColumnName("TREEPATH");
            //Property(t => t.CreatedTime).HasColumnName("CREATEDTIME");

            HasOptional(m => m.Parent).WithMany(n => n.Children);
            //HasOptional(m => m.Parent).WithMany(n => n.Children)
            //    .Map(p =>
            //        {
            //            p.MapKey("PARENT_ID");
            //        });

            //ToTable("ORGANIZATIONS");
        }
    }
}
