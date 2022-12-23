using FlashCardsWebAppMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlashCardsWebAppMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Was zur Hölle passiert hier
        public DbSet<Employee> Employees { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}