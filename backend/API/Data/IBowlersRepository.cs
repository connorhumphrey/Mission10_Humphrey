using API.Data;

namespace API.Data
{
    public interface IBowlersRepository
    {
        IEnumerable<Bowlers> Bowlers { get; }
    }
}


