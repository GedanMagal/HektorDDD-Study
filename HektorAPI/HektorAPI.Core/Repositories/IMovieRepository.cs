using System.Collections.Generic;
using System.Threading.Tasks;
using HektorAPI.Core.Entities;
using HektorAPI.Core.Repositories.Base;

namespace HektorAPI.Core.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<IEnumerable<Movie>> GetMoviesByDirectorName(string directorName);
    }
}