using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PenSoftAPI.Configuration;
using PenSoftAPI.Web;

namespace PenSoftAPI.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PenSoftAPIDbContextFactory : IDesignTimeDbContextFactory<PenSoftAPIDbContext>
    {
        public PenSoftAPIDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PenSoftAPIDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PenSoftAPIDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PenSoftAPIConsts.ConnectionStringName));

            return new PenSoftAPIDbContext(builder.Options);
        }
    }
}
