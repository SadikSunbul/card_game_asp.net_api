using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;
using Via.Persistence.Context;
using ViabelliWebProject.Packages.Core.Persistance.Repositories;

namespace Via.Persistence.Repositories.Cards;

public class PotionCardsRepository: EFBaseRepository<PotionCards, Guid, ViaBaseContext>,IPotionCardsRepository
{
    public PotionCardsRepository(ViaBaseContext context) : base(context)
    {
    }
}