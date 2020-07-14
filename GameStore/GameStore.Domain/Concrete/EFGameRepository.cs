using GameStore.Domain.Entities;
using GameStore.Domain.Abstract;
using System.Collections.Generic;

namespace GameStore.Domain.Concrete
{
    public class EFGameRepository : IGameRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Game> Games
        {
            get
            {
                return context.Games;
            }
        }
    }
}
