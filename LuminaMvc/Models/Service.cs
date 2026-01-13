using System.ComponentModel.DataAnnotations;

namespace LuminaMvc.Models
{
    public class Service
    {
        public int Id { get; set; } // Primary Key

        [Required]
        public string Title { get; set; } // e.g., "AI Integration"

        [Required]
        public string Description { get; set; }

        public string Price { get; set; } // e.g., "Starts at $500"
    }
}