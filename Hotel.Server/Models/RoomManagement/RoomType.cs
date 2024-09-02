using Hotel.Server.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Server.Models.RoomManagement
{
    public class RoomType
    {
        public int Id { get; set; }
        public string TypeName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int MaxOccupancy { get; set; }

        // Navigation properties
        public virtual ICollection<Room> Rooms { get; set; } = [];
    }
}
