using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;
using Via.Persistence.Context;
using ViabelliWebProject.Packages.Core.Persistance.Repositories;

namespace Via.Persistence.Repositories.Cards;

public class MonsterCardsRepository: EFBaseRepository<MonsterCards, Guid, ViaBaseContext>,IMonsterCardsRepository
{
    public MonsterCardsRepository(ViaBaseContext context) : base(context)
    {
    }
}