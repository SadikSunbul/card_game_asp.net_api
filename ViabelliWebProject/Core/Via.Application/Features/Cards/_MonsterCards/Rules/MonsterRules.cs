using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;
using ViabelliWebProject.Packages.Core.CrossCuttingConcerns.Exceptions.Types;
using ViabelliWebProject.Packages.Core.CrossCuttingConcerns.Rules;

namespace Via.Application.Features.Cards._MonsterCards.Rules;

public class MonsterRules:BaseRules
{
    private readonly IMonsterCardsRepository _repository;

    public MonsterRules(IMonsterCardsRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<MonsterCards> IsThereACard(Guid id)
    {
        MonsterCards? control=await _repository.GetAsync(i=>i.Id==id);
        
        if (control == null)
            throw new ValidationException("Aranan kart yok");
        return control;
    }
    
    public async Task<MonsterCards> IsThereACard(string Name)
    {
        MonsterCards? control=await _repository.GetAsync(i => i.Name.ToLower() ==Name.ToLower());
        
        if (control == null)
            throw new ValidationException("Aranan kart yok");
        return control;
    }
}