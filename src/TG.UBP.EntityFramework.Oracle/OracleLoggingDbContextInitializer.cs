using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSharp.Data.Entity.Logging;

namespace TG.UBP.EntityFramework.Oracle
{
    public class OracleLoggingDbContextInitializer : OracleDbContextInitializerBase<LoggingDbContext>
    {
        /// <summary>
        /// 初始化一个<see cref="OracleLoggingDbContextInitializer"/>新实例
        /// </summary>
        public OracleLoggingDbContextInitializer()
        {
            CreateDatabaseInitializer = MigrateInitializer
                = new MigrateDatabaseToLatestVersion<LoggingDbContext, OracleLoggingMigrationsConfiguration>();
        }
    }
}
