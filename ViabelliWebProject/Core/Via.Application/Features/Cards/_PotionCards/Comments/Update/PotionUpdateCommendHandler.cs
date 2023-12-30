using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._PotionCards.Rules;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._PotionCards.Comments.Update;

public class
    PotionUpdateCommendHandler : IRequestHandler<PotionUpdateCommendRequest, PotionUpdateCommendRespons>
{
    private readonly IMapper mapper;
    private readonly IPotionCardsRepository _repository;
    private readonly PotionRules _rules;

    public PotionUpdateCommendHandler(IMapper mapper, IPotionCardsRepository repository, PotionRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<PotionUpdateCommendRespons> Handle(PotionUpdateCommendRequest request,
        CancellationToken cancellationToken)
    {
        PotionCards? card = await _rules.IsThereACard(request.Id);

        if (request.Name != null)
            card.Name = request.Name;
        if (request.PngUrl != null)
            card.PngUrl = request.PngUrl;
        if (request.CopyCount != null)
            card.CopyCount = request.CopyCount.Value;
        if (request.Talk != null)
            card.Talk = request.Talk;
        if (request.Type != null)
            card.Type = request.Type;
        if (request.HealthGain != null)
            card.HealthGain = request.HealthGain.Value;
        if (request.MoneyGain != null)
            card.MoneyGain = request.MoneyGain.Value;
        if (request.Bonus != null)
            card.Bonus = request.Bonus;

        await _repository.UpdateAsync(card);
        return mapper.Map<PotionUpdateCommendRespons>(card);
    }
}