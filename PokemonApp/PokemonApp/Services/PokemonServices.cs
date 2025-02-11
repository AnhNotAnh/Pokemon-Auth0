using PokemonApp.Context;
using PokemonApp.Dto;
using PokemonApp.Interfaces;
using PokemonApp.Models;

namespace PokemonApp.Services
{
    public class PokemonServices : IPokemonServices
    {
        private readonly PokemonAppDbContext _context;

        public PokemonServices(PokemonAppDbContext context)
        {
            _context = context;
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemons.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Pokemon> GetPokemons()
        {
            return _context.Pokemons.ToList();
        }

        public bool PostPokemon(Pokemon pokemon)
        {
            _context.Pokemons.Add(pokemon);
            _context.SaveChanges();


            return true;
        }
    }
}
