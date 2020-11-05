using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicLibrary;

namespace DrMusicRepo
{
    public class ItemContext : DbContext
    {

        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {

        }

        public DbSet<Record> Records { get; set; }

    }
}
