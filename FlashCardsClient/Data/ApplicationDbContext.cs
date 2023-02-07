using FlashCardsWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FlashCardsWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Unsere "DB Tabellen"
        public DbSet<Karteikarte> Karteikarten { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}