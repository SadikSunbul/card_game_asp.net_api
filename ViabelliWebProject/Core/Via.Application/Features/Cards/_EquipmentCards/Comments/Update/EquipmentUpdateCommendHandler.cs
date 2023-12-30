using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._EquipmentCards.Rules;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._EquipmentCards.Comments.Update;

public class
    EquipmentUpdateCommendHandler : IRequestHandler<EquipmentUpdateCommendRequest,
        EquipmentUpdateCommendRespons>
{
    private readonly IMapper mapper;
    private readonly IEquipmentCardsRepository _repository;
    private readonly EquipmentRules _rules;

    public EquipmentUpdateCommendHandler(IMapper mapper, IEquipmentCardsRepository repository,
        EquipmentRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<EquipmentUpdateCommendRespons> Handle(EquipmentUpdateCommendRequest request,
        CancellationToken cancellationToken)
    {
        EquipmentCards? card = await _rules.IsThereACard(request.Id);

        if (request.Name != null)
            card.Name = request.Name;
        if (request.Power != null)
            card.Power = request.Power.Value;
        if (request.PngUrl != null)
            card.PngUrl = request.PngUrl;
        if (request.CopyCount != null)
            card.CopyCount = request.CopyCount.Value;
        if (request.Talk != null)
            card.Talk = request.Talk;
        if (request.Cost != null)
            card.Cost = request.Cost.Value;
        if (request.Type != null)
            card.Type = request.Type;
        if (request.Bonus != null)
            card.Bonus = request.Bonus;

        await _repository.UpdateAsync(card);
        return mapper.Map<EquipmentUpdateCommendRespons>(card);
    }
}