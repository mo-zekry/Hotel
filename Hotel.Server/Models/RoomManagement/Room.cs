using Hotel.Server.Models.Common;
using Hotel.Server.Models.HousekeepingMaintenance;
using Hotel.Server.Models.Statues;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Server.Models.RoomManagement
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; } = null!;
        public int RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; } = null!;
        public RoomStatus Status { get; set; }
        public decimal PricePerNight { get; set; }

        // Navigation properties
        public virtual ICollection<Booking> Bookings { get; set; } = [];
        public virtual ICollection<HousekeepingTask> HousekeepingTasks { get; set; } = [];
        public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = [];
    }

}
