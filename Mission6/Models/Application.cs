using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class Application
    {
        [Required]
        public int ApplicationID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        [Range(1888,2025)]
        public string Director { get; set; }
        public int Rating { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
        public bool Edited { get; set; }
      

    }
}
