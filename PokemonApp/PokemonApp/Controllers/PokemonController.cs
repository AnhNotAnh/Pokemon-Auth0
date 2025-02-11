using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonApp.Dto;
using PokemonApp.Interfaces;
using PokemonApp.Models;

namespace PokemonApp.Controllers
{
    [Route("api/pokemons")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private IPokemonServices _pokemonServices;
        private IMapper _mapper;

        public PokemonController(IPokemonServices pokemonServices, IMapper mapper)
        {
            _pokemonServices = pokemonServices;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Pokemon>> FindPokemons()
        {
            var pokemons = _mapper.Map<List<PokemonDTO>>(_pokemonServices.GetPokemons());

            if (pokemons is null)
            {
                return NotFound();
            }

            return Ok(pokemons);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Pokemon>> FindOnePokemon(string id)
        {
            var pokemons = _mapper.Map<PokemonDTO>(_pokemonServices.GetPokemon(Int32.Parse(id)));

            if (pokemons is null)
            {
                return NotFound();
            }

            return Ok(pokemons);
        }

        [HttpPost, Authorize]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<IEnumerable<Pokemon>> InserPokemon([FromBody] PokemonDTO pokemon)
        {
            var pokemonModel = _mapper.Map<Pokemon>(pokemon);

            var result = _pokemonServices.PostPokemon(pokemonModel);

            if (result)
            {
                ModelState.AddModelError("", "failed to update");
            }

            return Ok("Update successfully");
        }

    }
}
