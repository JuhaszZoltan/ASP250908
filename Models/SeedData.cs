using Microsoft.EntityFrameworkCore;
using MvcMovies.Data;

namespace MvcMovies.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMoviesContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMoviesContext>>()))
        {
            if (context.Movie.Any()) return;

            context.Movie.AddRange(
                new Movie //01
                {
                    Title = "Harry Potter and the Philosopher's Stone",
                    ReleaseDate = DateTime.Parse("2001-11-04"),
                    Genre = "Adventure",
                    Price = 7.99M,
                    Rating = "R",
                },
                new Movie //02
                {
                    Title = "Harry Potter and the Chamber of Secrets",
                    ReleaseDate = DateTime.Parse("2002-11-03"),
                    Genre = "Adventure",
                    Price = 8.99M,
                    Rating = "R",
                },
                new Movie //03
                {
                    Title = "Harry Potter and the Prisoner of Azkaban",
                    ReleaseDate = DateTime.Parse("2004-05-23"),
                    Genre = "Adventure",
                    Price = 6.99M,
                    Rating = "R",
                },
                new Movie //04
                {
                    Title = "Harry Potter and the Goblet of Fire",
                    ReleaseDate = DateTime.Parse("2005-11-05"),
                    Genre = "Adventure",
                    Price = 7.99M,
                    Rating = "R",
                }
            );
            context.SaveChanges();
        }
    }
}
