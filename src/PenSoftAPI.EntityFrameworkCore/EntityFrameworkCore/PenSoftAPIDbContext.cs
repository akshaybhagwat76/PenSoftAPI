using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PenSoftAPI.Authorization.Roles;
using PenSoftAPI.Authorization.Users;
using PenSoftAPI.MultiTenancy;

namespace PenSoftAPI.EntityFrameworkCore
{
    public class PenSoftAPIDbContext : AbpZeroDbContext<Tenant, Role, User, PenSoftAPIDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PenSoftAPIDbContext(DbContextOptions<PenSoftAPIDbContext> options)
            : base(options)
        {
        }
    }
}
