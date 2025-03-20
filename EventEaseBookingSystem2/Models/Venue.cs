using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;

namespace EventEaseBooking.Models
{
    public class Venue
    {
        public int VenueId { get; set; }

        [Required]
        [Display(Name = "Venue Name")]
        public string VenueName { get; set; } = string.Empty;

        [Required]
        public string Location { get; set; } = string.Empty;

        [Required]
        [Range(1, 10000)]
        public int Capacity { get; set; }

        [Display(Name = "Image URL")]
        public string? ImageUrl { get; set; }

        // Navigation property
        public virtual ICollection<Event>? Events { get; set; }
    }
}