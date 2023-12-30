using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;
using Via.Persistence.Context;
using ViabelliWebProject.Packages.Core.Persistance.Repositories;

namespace Via.Persistence.Repositories.Cards;

public class CardRepository: EFBaseRepository<Card, Guid, ViaBaseContext>, ICardRepository
{
    public CardRepository(ViaBaseContext context) : base(context)
    {
    }
}