using AdstraTask.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdstraTask.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            this.SeedUsers(builder);
            this.SeedRoles(builder);

        }

        private void SeedUsers(ModelBuilder builder)
        {

            builder.Entity<IdentityUser>().HasData(new IdentityUser()
            {
                UserName = "Admin",
                Email = "Admin@gmail.com",
                PhoneNumber = "12343545",
                PasswordHash = "Admin*123",
                NormalizedEmail = "Admin@gmail.com",
                NormalizedUserName = "Admin"
            });
            builder.Entity<IdentityUser>().HasData(new IdentityUser()
            {
                UserName = "User",
                Email = "User@gmail.com",
                PhoneNumber = "43836287389",
                PasswordHash = "User*123",
                NormalizedEmail = "User@gmail.com",
                NormalizedUserName = "User"
            });

        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "User", ConcurrencyStamp = "2", NormalizedName = "User" }
                );
        }



        public DbSet<Contact> Contacts { get; set; }


    }
}