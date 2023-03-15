using PokemonReviewApp.Data;
using PokemonReviewApp.Interface;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context) { 
        }
        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(propa => propa.Id).ToList();
        }
    }
}
