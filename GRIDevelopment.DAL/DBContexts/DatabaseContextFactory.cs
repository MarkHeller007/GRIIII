using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace GRIDevelopment.DAL.DBContexts
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<GRIContext>
    {
        public GRIContext CreateDbContext(string[] args)
        {
            AppConfiguration appConfig = new AppConfiguration();
            var opsBuilder = new DbContextOptionsBuilder<GRIContext>();
            opsBuilder.UseSqlServer(appConfig.sqlConnectionString);
            return new GRIContext(opsBuilder.Options);
        }
    }
}
