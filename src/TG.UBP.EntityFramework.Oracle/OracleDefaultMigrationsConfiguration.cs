using OSharp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.EntityFramework.Oracle
{
    public class OracleDefaultMigrationsConfiguration : OracleMigrationsConfigurationWithSeedBase<DefaultDbContext>
    {
        public OracleDefaultMigrationsConfiguration()
        {
            SeedActions.Add(new OracleDefaultMigrationsSeedAction());
        }
    }
}
