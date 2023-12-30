using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;
using Via.Persistence.Context;
using ViabelliWebProject.Packages.Core.Persistance.Repositories;

namespace Via.Persistence.Repositories.Cards;

public class EquipmentCardsRepository: EFBaseRepository<EquipmentCards, Guid, ViaBaseContext>,IEquipmentCardsRepository
{
    public EquipmentCardsRepository(ViaBaseContext context) : base(context)
    {
    }
}