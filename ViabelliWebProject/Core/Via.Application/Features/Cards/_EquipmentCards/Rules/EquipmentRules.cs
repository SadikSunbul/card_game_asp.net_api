using System.ComponentModel.DataAnnotations;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;
using ViabelliWebProject.Packages.Core.CrossCuttingConcerns.Rules;

namespace Via.Application.Features.Cards._EquipmentCards.Rules;

public class EquipmentRules : BaseRules
{
    private readonly IEquipmentCardsRepository _repository;

    public EquipmentRules(IEquipmentCardsRepository repository)
    {
        _repository = repository;
    }

    public async Task<EquipmentCards> IsThereACard(Guid id)
    {
        EquipmentCards? control = await _repository.GetAsync(i => i.Id == id);

        if (control == null)
            throw new ValidationException("Aranan kart yok");
        return control;
    }

    public async Task<EquipmentCards> IsThereACard(string Name)
    {
        EquipmentCards? control = await _repository.GetAsync(i => i.Name.ToLower() == Name.ToLower());

        if (control == null)
            throw new ValidationException("Aranan kart yok");
        return control;
    }
}