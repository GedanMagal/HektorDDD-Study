using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HektorAPI.Core.Entities;
using HektorAPI.Core.Repositories;
using HektorAPI.Infra.Data;
using HektorAPI.Infra.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace HektorAPI.Infra.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public async Task<IEnumerable<Movie>> GetMoviesByDirectorName(string directorName)
        {
            return await _context.Movies
                .Where(m => m.DirectorName == directorName)
                .ToListAsync();
        }

    }
}