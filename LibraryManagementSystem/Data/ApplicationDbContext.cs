using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Data
{
    public class ApplicationDbContext  : IdentityDbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }   
        public DbSet<StudentInfo> Students { get; set; }    
        public DbSet<Register> Registers { get; set; }   
        public DbSet<Login> Logins { get; set; } 

    }
}
