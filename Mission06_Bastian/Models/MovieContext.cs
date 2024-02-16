using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Mission06_Bastian.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) //Constructor
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
