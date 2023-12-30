using Via.Domain.Entities.CardGame;
using ViabelliWebProject.Packages.Core.Persistance.Repositories;

namespace Via.Application.Services.Repositories.Cards;

public interface IMoneyCardsRepository: IAsyncRepository<MoneyCards, Guid>
{
    
}