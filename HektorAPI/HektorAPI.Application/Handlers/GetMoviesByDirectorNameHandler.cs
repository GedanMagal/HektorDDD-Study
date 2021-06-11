using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HektorAPI.Application.Mappers;
using HektorAPI.Application.Responses;
using HektorAPI.Core.Repositories;
using MediatR;

namespace HektorAPI.Application.Queries
{
    public class GetMoviesByDirectorNameHandler : IRequestHandler<GetMoviesByDirectorNameQuery, IEnumerable<MovieResponse>>
    {
        private readonly IMovieRepository _movieRepository;

        public GetMoviesByDirectorNameHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<MovieResponse>> Handle(GetMoviesByDirectorNameQuery request, CancellationToken cancellationToken)
        {
            var movieList = await _movieRepository.GetMoviesByDirectorName(request.DirectorName);
            var movieResponseList = MovieMapper.Mapper.Map<IEnumerable<MovieResponse>>(movieList);
            return movieResponseList;

        }
    }
}