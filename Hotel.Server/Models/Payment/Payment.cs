using Hotel.Server.Models.Common;
using Hotel.Server.Models.RoomManagement;
using Hotel.Server.Models.Statues;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Server.Models.Payment
{
    public class Payment
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public virtual Booking Booking { get; set; } = null!;
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }
    }

}
