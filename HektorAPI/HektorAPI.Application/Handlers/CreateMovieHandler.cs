using System.Threading;
using System.Threading.Tasks;
using HektorAPI.Application.Responses;
using HektorAPI.Core.Repositories;
using MediatR;

namespace HektorAPI.Application.Handlers
{
    public class CreateMovieHandler : IRequestHandler<CreateMovieCommand, MovieResponse>
    {
        public readonly IMovieRepository _movieRepository;

        public CreateMovieHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }


        public Task<MovieResponse> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}