using FlashWordsEFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashWordsEFDataAccessLibrary.DataAccess
{
    internal class VocabularyContext : DbContext
    {
        public VocabularyContext(DbContextOptions options) : base(options) { }

        public DbSet<Vocabulary> Vocabularies { get; set; }

        public DbSet<Wordtype> Wordtypes { get; set; }
    }
}
