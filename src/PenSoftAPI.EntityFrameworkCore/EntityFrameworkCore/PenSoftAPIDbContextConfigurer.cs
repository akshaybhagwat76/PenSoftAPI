using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PenSoftAPI.EntityFrameworkCore
{
    public static class PenSoftAPIDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PenSoftAPIDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PenSoftAPIDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
