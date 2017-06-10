using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSharp.Data.Entity;

namespace TG.UBP.EntityFramework.Oracle
{
    /// <summary>
    /// Oracle数据上下文初始化
    /// </summary>
    public class OracleDefaultDbContextInitializer : OracleDbContextInitializerBase<DefaultDbContext>
    {
        /// <summary>
        /// 初始化一个<see cref="OracleDefaultDbContextInitializer"/>新实例
        /// </summary>
        public OracleDefaultDbContextInitializer()
        {
            CreateDatabaseInitializer = MigrateInitializer
                = new MigrateDatabaseToLatestVersion<DefaultDbContext, OracleDefaultMigrationsConfiguration>();
        }
    }
}
