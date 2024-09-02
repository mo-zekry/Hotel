using Hotel.Server.Models.Common;
using Hotel.Server.Models.EmployeeManagement;
using Hotel.Server.Models.RoomManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Server.Models.HousekeepingMaintenance
{
    public class HousekeepingTask
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; } = null!;
        public DateTime ScheduledDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int AssignedToEmployeeId { get; set; }
        public virtual Employee AssignedTo { get; set; } = null!;
        public TaskStatus Status { get; set; }
    }

}
