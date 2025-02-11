namespace PokemonApp.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string Country { get; set; }

        public Reviewer Reviewer { get; set; }

        public Pokemon Pokemon { get; set; }
        public int PokemonId { get; internal set; }
        public int ReviewerId { get; internal set; }
    }
}
