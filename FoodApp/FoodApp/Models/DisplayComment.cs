using System.ComponentModel.DataAnnotations;

namespace FoodApp.Models
{
    public class DisplayComment
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Note { get; set; }
    }
}
