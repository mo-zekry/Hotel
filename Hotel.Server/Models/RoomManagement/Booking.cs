using Hotel.Server.Models.Common;
using Hotel.Server.Models.GuestManagement;
using Hotel.Server.Models.Statues;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Server.Models.RoomManagement
{
    public class Booking
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public virtual Guest Guest { get; set; } = null!;
        public int RoomId { get; set; }
        public virtual Room Room { get; set; } = null!;
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public BookingStatus Status { get; set; }
        public decimal TotalAmount { get; set; }

        // Navigation properties
        public virtual ICollection<PaymentMethod> Payments { get; set; } = [];
    }
}
