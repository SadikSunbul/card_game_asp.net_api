using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;
using ViabelliWebProject.Packages.Core.CrossCuttingConcerns.Exceptions.Types;
using ViabelliWebProject.Packages.Core.CrossCuttingConcerns.Rules;

namespace Via.Application.Features.Cards._PotionCards.Rules;

public class PotionRules : BaseRules
{
    private readonly IPotionCardsRepository _repository;

    public PotionRules(IPotionCardsRepository repository)
    {
        _repository = repository;
    }

    public async Task<PotionCards> IsThereACard(Guid id)
    {
        PotionCards? control = await _repository.GetAsync(i => i.Id == id);

        if (control == null)
            throw new ValidationException("Aranan kart yok");
        return control;
    }

    public async Task<PotionCards> IsThereACard(string Name)
    {
        PotionCards? control = await _repository.GetAsync(i => i.Name.ToLower() == Name.ToLower());

        if (control == null)
            throw new ValidationException("Aranan kart yok");
        return control;
    }
}