using AutoMapper;
using HektorAPI.Application.Responses;
using HektorAPI.Core.Entities;

namespace HektorAPI.Application.Mappers
{
    public class MovieMappingProfile : Profile
    {
        public MovieMappingProfile()
        {
            CreateMap<Movie, MovieResponse>().ReverseMap();
            CreateMap<Movie, CreateMovieCommand>().ReverseMap();
        }

    }
}