namespace BusTicket.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BusTicket : DbContext
    {
        public BusTicket()
            : base("name=filiz")
        {
        }

        public virtual DbSet<Buses> Buses { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Routes> Routes { get; set; }
        public virtual DbSet<Seats> Seats { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<TimeSlots> TimeSlots { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buses>()
                .HasMany(e => e.Seats)
                .WithOptional(e => e.Buses)
                .HasForeignKey(e => e.Bus_ID);

            modelBuilder.Entity<Buses>()
                .HasMany(e => e.Tickets)
                .WithOptional(e => e.Buses)
                .HasForeignKey(e => e.Bus_ID);

            modelBuilder.Entity<Buses>()
                .HasMany(e => e.TimeSlots)
                .WithOptional(e => e.Buses)
                .HasForeignKey(e => e.Bus_ID);

            modelBuilder.Entity<Buses>()
                .HasMany(e => e.Routes)
                .WithMany(e => e.Buses)
                .Map(m => m.ToTable("RouteBus").MapLeftKey("Bus_ID").MapRightKey("Route_ID"));

            modelBuilder.Entity<People>()
                .HasMany(e => e.Tickets)
                .WithOptional(e => e.People)
                .HasForeignKey(e => e.Person_ID);

            modelBuilder.Entity<People>()
                .HasMany(e => e.Tickets1)
                .WithOptional(e => e.People1)
                .HasForeignKey(e => e.Staff_ID);

            modelBuilder.Entity<Routes>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Routes>()
                .HasMany(e => e.Tickets)
                .WithOptional(e => e.Routes)
                .HasForeignKey(e => e.Route_ID);

            modelBuilder.Entity<Tickets>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TimeSlots>()
                .HasMany(e => e.Tickets)
                .WithOptional(e => e.TimeSlots)
                .HasForeignKey(e => e.TimeSlot_ID);
        }
    }
}
