using System.Linq;
using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class EFBowlersRepository : IBowlersRepository
    {
        private readonly BowlersContext _bowlingContext;

        public EFBowlersRepository(BowlersContext context)
        {
            _bowlingContext = context;
        }

        public IEnumerable<Bowlers> Bowlers => _bowlingContext.Bowlers
            .Include(b => b.Team) // Eager loading the Team navigation property
            .ToList();
    }
}
