using System.Collections;
using System.Collections.Generic;
using HektorAPI.Application.Responses;
using MediatR;

namespace HektorAPI.Application.Queries
{
    public class GetMoviesByDirectorNameQuery : IRequest<IEnumerable<MovieResponse>>
    {
        public string DirectorName { get; set; }

        public GetMoviesByDirectorNameQuery(string directorName)
        {
            DirectorName = directorName;
        }

    }
}