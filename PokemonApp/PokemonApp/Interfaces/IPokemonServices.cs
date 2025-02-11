using PokemonApp.Models;

namespace PokemonApp.Interfaces
{
    public interface IPokemonServices
    {
        IEnumerable<Pokemon> GetPokemons();

        Pokemon GetPokemon(int id);

        bool PostPokemon(Pokemon pokemon);


    }
}
