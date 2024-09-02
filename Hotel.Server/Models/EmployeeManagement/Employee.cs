using Hotel.Server.Models.HousekeepingMaintenance;
using Hotel.Server.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Server.Models.EmployeeManagement
{
    public class Employee
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;
        public string Position { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public DateTime DateOfJoining { get; set; }

        // Navigation properties
        public virtual ICollection<ShiftAssignment> Shifts { get; set; } = [];
        public virtual ICollection<HousekeepingTask> HousekeepingTasks { get; set; } = [];
        public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = [];
    }

}
