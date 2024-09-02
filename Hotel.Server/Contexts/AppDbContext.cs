using Hotel.Server.Models.Common;
using Hotel.Server.Models.EmployeeManagement;
using Hotel.Server.Models.EventManagement;
using Hotel.Server.Models.GuestManagement;
using Hotel.Server.Models.HousekeepingMaintenance;
using Hotel.Server.Models.Identity;
using Hotel.Server.Models.RoomManagement;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Server.Contexts
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        //----------------------------------------------
        // DbSet
        //----------------------------------------------
        // DbSet for EmployeeManagement
        public DbSet<Employee> Employee { get; set; }
        public DbSet<ShiftAssignment> ShiftAssignment { get; set; }

        // DbSet for EventManagement
        public DbSet<Event> Event { get; set; }
        public DbSet<EventSpace> EventSpace { get; set; }

        // DbSet for GuestManagement
        public DbSet<Guest> Guest { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<GuestPreference> GuestPreference { get; set; }

        // DbSet for HousekeepingMaintenance
        public DbSet<HousekeepingTask> HousekeepingTask { get; set; }
        public DbSet<MaintenanceRequest> MaintenanceRequest { get; set; }

        // DbSet for RoomManagement
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<Booking> Booking { get; set; }

        //*************** TODO: payment later ************

        //----------------------------------------------
        // Overriding methods
        //----------------------------------------------

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // get configuration from appsettings.json
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(config);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
