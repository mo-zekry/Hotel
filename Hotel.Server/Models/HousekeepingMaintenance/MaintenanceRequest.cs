using Hotel.Server.Models.Common;
using Hotel.Server.Models.EmployeeManagement;
using Hotel.Server.Models.RoomManagement;
using Hotel.Server.Models.Statues;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Server.Models.HousekeepingMaintenance
{
    public class MaintenanceRequest
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; } = null!;
        public DateTime RequestDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int AssignedToEmployeeId { get; set; }
        public virtual Employee AssignedTo { get; set; } = null!;
        public string IssueDescription { get; set; } = string.Empty;
        public RequestStatus Status { get; set; }
    }

}
