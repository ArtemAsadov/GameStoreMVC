using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Entities.Abstract
{
    interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
    }
}
