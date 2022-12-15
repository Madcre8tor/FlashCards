using FlashWordsEFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace FlashWordsEFDataAccessLibrary.DataAccess
{
    public class WordtypeContext : DbContext
    {
        public WordtypeContext(DbContextOptions options) : base(options) { }

    }
}