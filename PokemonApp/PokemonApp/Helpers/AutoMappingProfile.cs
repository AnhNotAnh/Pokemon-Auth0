using AutoMapper;
using PokemonApp.Dto;
using PokemonApp.Models;

namespace PokemonApp.Helpers
{
    public class AutoMappingProfile: Profile
    {
       public AutoMappingProfile() 
       {
            CreateMap<Pokemon, PokemonDTO>();
            CreateMap<PokemonDTO, Pokemon>();

       }
    }
}
