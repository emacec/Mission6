using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }
        [Range(1888,2025, ErrorMessage = "Year must be between 1888 and 2025.")]


        public string? Director { get; set; }
        public int? Rating { get; set; }

        [Required]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; }


        public string? Notes { get; set; }

        

        //connects category and application
        public Category Category { get; set; }

    }
}
