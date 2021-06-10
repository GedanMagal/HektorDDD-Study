using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HektorAPI.Core.Entities;
using Microsoft.Extensions.Logging;

namespace HektorAPI.Infra.Data
{
    public class ApplicationContextSeed
    {
        public static async Task SeedAsync(ApplicationContext context, ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;
            try
            {
                await context.Database.EnsureCreatedAsync();

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(GetMovies());
                    await context.SaveChangesAsync();
                }

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao conectar no banco de dados", e);
            }

        }

        private static IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
          {
              new Movie("Avatar","James Cameron","2009"),
              new Movie("Titanic","James Cameron","1997"),
              new Movie("Die Another Day", "Lee Tamahori","2002"),
              new Movie("Godzilla", "Gareth Edwards","2014")
          };
        }
    }
}