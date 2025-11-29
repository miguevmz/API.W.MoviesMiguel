using API.W.Movies.DAL.Models;
using API.W.Movies.DAL.Models.Dtos;
using AutoMapper;

namespace API.W.Movies.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            //GATEGORY
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateUpdateDto>().ReverseMap();

            //MOVIE

            CreateMap<Movie, MovieDto>().ReverseMap(); 
            CreateMap<Movie, MovieCreateUpdateDto>().ReverseMap(); 
        }
    }
}
