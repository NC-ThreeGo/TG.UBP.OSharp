using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSharp.Core.Data;
using OSharp.Data.Entity.Migrations;

namespace TG.UBP.EntityFramework.Oracle
{
    public abstract class OracleMigrationsConfigurationWithSeedBase<TContext> : MigrationsConfigurationWithSeedBase<TContext>
        where TContext : DbContext, IUnitOfWork
    {
        private const string ProviderName = "Devart.Data.Oracle";

        /// <summary>
        /// 初始化一个<see cref="OracleMigrationsConfiguration{TContext}"/>类型的新实例
        /// </summary>
        public OracleMigrationsConfigurationWithSeedBase()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = typeof(TContext).FullName;

            SetSqlGenerator(ProviderName, new Devart.Data.Oracle.Entity.Migrations.OracleEntityMigrationSqlGenerator());
        }
    }
}
