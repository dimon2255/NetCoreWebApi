using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.DataModels
{
    /// <summary>
    /// POCO class for tickets
    /// </summary>
    public class TicketItem
    {
        public long Id { get; set; }
        public string Concert { get; set; }
        public string Artist { get; set; }
        public bool Available { get; set; }
    }

    /// <summary>
    /// Data store context
    /// </summary>
    public class TicketDbContext : DbContext
    {
        /// <summary>
        /// Represents table of ticket items
        /// </summary>
        public DbSet<TicketItem> TicketItems { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="options"></param>
        public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Sets up primary key
            modelBuilder.Entity<TicketItem>().HasKey(k => k.Id);
        }
    }
}
