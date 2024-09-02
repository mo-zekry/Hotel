using Hotel.Server.Models.Common;
using Hotel.Server.Models.EmployeeManagement;
using Hotel.Server.Models.RoomManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Server.Models.EventManagement
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public int EventSpaceId { get; set; }
        public virtual EventSpace EventSpace { get; set; } = null!;
        public int CoordinatorId { get; set; }
        public virtual Employee Coordinator { get; set; } = null!;

        // Navigation properties
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }


}
