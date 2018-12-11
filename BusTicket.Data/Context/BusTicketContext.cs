using BusTicket.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Data.Context
{
    public class BusTicketContext : DbContext
    {
        public BusTicketContext() : base("baglantim")
        {}

        //singleton pattern ile contextten bir tane üret
        private static BusTicketContext _context;
        //static kaldırdım 
        public BusTicketContext CreateContext()
        {
            if (_context == null)
            {
                _context = new BusTicketContext();
            }
            return _context;
        }


        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<TimeSlot> Times { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }


}
