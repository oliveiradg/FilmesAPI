using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data
{
    public class FilmeContext : DbContext
    {
        public  FilmeContext (DbContextOptions<FilmeContext> options)
            : base(options)
        {

        }

        public DbSet<FilmesModel> Filmes { get; set; }
        

        }
    }
}
