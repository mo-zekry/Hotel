using Hotel.Server.Models.Common;
using Hotel.Server.Models.Identity;
using Hotel.Server.Models.RoomManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Server.Models.GuestManagement
{
    public class Guest
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;

        // Navigation properties
        public virtual ICollection<GuestPreference> Preferences { get; set; } = [];
        public virtual ICollection<Booking> Bookings { get; set; } = [];
        public virtual ICollection<Feedback> Feedbacks { get; set; } = [];
    }
}
