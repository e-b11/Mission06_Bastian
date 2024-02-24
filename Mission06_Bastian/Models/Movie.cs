using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Bastian.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        public int CopiedToPlex { get; set; }
        [StringLength(25)]
        public string? Notes { get; set; }

    }
}
