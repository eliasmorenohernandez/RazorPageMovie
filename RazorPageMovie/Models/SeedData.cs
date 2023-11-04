using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Data;

namespace RazorPageMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) 
        {
            using (var context = new RazorPageMovieContext1(
                serviceProvider.GetRequiredService<
                DbContextOptions<RazorPageMovieContext1>>()))
            {
                //Se verifica de que el context es null, se envia mensaje de error
                if(context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPAgeMovieContext");
                }
                if(context.Movie.Any())
                {
                    // La BD retorna o muestra todo lo que contiene esta clase
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When HArry met Sally",
                        RelaseDate = DateTime.Parse("1989-2-12"),
                        Genre="Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Goshbusters",
                        RelaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "G"
                    },
                    new Movie
                    {
                        Title = "Goshbusters 2",
                        RelaseDate = DateTime.Parse("1989-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "G"
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        RelaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "NA"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
