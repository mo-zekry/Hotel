using Hotel.Server.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Server.Models.EventManagement
{
    public class EventSpace
    {
        public int Id { get; set; }
        public string SpaceName { get; set; } = null!;
        public int Capacity { get; set; }
        public decimal PricePerHour { get; set; }

        // Navigation properties
        public virtual ICollection<Event> Events { get; set; } = [];
    }

}
