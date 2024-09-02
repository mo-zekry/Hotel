using Hotel.Server.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Server.Models.GuestManagement
{
    public class Feedback
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public virtual Guest Guest { get; set; } = null!;
        public string Comments { get; set; } = string.Empty;
        public int Rating { get; set; }
        public DateTime FeedbackDate { get; set; }
    }

}
