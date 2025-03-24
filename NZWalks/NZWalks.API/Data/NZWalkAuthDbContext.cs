using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NZWalks.API.Data
{
    public class NZWalkAuthDbContext : IdentityDbContext
    {
        public NZWalkAuthDbContext(DbContextOptions<NZWalkAuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Creating new roles to seed data
            //The Guid IDs are generated using C# Interactive window
            var readerRoleId = "ede5f8e6-50dc-41b6-b0c4-b8cda874661d";
            var writerRoleId = "36019e63-7e09-4388-8397-a70229cedfe0";

            var roles = new List<IdentityRole>() {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper()
                },
                new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                }
            };

            //Seed data when we run migrations
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
