using System.Collections.Generic;
using System.Threading.Tasks;
using HektorAPI.Application.Queries;
using HektorAPI.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HektorAPI.Api.Controllers
{
    public class MovieController : ApiController
    {
        private readonly IMediator _mediator;

        public MovieController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<MovieResponse>>> GetMoviesByDirectorName(string directorName)
        {
            var query = new GetMoviesByDirectorNameQuery(directorName);
            var result = await _mediator.Send(query);
            return Ok(result);

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<MovieResponse>> CreateMovie([FromBody] CreateMovieCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}