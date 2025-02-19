﻿namespace PokemonApp.Models
{
    public class Owner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gym { get; set; }

        public string Country { get; set; }

        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}
