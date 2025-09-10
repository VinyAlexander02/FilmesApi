using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class FilmProfile : Profile {
    public FilmProfile()
    {
        CreateMap<CreateFilmDto, Film>();
    }
}