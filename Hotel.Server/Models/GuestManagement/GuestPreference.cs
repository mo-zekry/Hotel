using Hotel.Server.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Server.Models.GuestManagement
{
    public class GuestPreference
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public virtual Guest Guest { get; set; } = null!;
        public string PreferenceType { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

}
