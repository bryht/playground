using DartBoard.Domain.Entities;
using DartBoard.Persistence;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DartBoard.Application.Queries
{
    public class GetGamesQueryHandler : IRequestHandler<GetGamesQuery, List<Game>>
    {
        private readonly DataBaseContext dataBaseContext;

        public GetGamesQueryHandler(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }

        public Task<List<Game>> Handle(GetGamesQuery request, CancellationToken cancellationToken)
        {
            var games=dataBaseContext.Games.ToList();
            return Task.FromResult(games);
        }
    }
}

