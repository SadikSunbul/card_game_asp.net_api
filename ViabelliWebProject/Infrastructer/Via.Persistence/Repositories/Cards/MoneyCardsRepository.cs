using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;
using Via.Persistence.Context;
using ViabelliWebProject.Packages.Core.Persistance.Repositories;

namespace Via.Persistence.Repositories.Cards;

public class MoneyCardsRepository: EFBaseRepository<MoneyCards, Guid, ViaBaseContext>,IMoneyCardsRepository
{
    public MoneyCardsRepository(ViaBaseContext context) : base(context)
    {
    }
}