using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;
using ViabelliWebProject.Packages.Core.CrossCuttingConcerns.Exceptions.Types;
using ViabelliWebProject.Packages.Core.CrossCuttingConcerns.Rules;

namespace Via.Application.Features.Cards._MonetCards.Rules;

public class MoneyRules:BaseRules
{
    private readonly IMoneyCardsRepository _repository;

    public MoneyRules(IMoneyCardsRepository repository)
    {
        _repository = repository;
    }
    public async Task<MoneyCards> IsThereACard(Guid id)
    {
        MoneyCards? control=await _repository.GetAsync(i=>i.Id==id);
        
        if (control == null)
            throw new ValidationException("Aranan kart yok");
        return control;
    }
    
    public async Task<MoneyCards> IsThereACard(string Name)
    {
        MoneyCards? control=await _repository.GetAsync(i => i.Name.ToLower() ==Name.ToLower());
        
        if (control == null)
            throw new ValidationException("Aranan kart yok");
        return control;
    }
    
}