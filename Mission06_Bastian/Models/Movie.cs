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
        public Category? Category { get; set; }
        [Required(ErrorMessage ="You must enter a title.")]
        public string Title { get; set; }
        [Range (1888, Int32.MaxValue,ErrorMessage="You must enter a year of at least 1888.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required(ErrorMessage = "You must select an option for Edited.")]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required(ErrorMessage = "You must select an option for Copied To Plex.")]
        public bool CopiedToPlex { get; set; }
        [StringLength(25)]
        public string? Notes { get; set; }

    }
}
