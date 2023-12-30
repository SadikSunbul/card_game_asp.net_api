using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._MonetCards.Comments.Delete;
using Via.Application.Features.Cards._MonetCards.Rules;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._MonetCards.Comments.Update;

public class MoneyUpdateCommendHandler : IRequestHandler<MoneyUpdateCommendRequest, MoneyUpdateCommendRespons>
{
    private readonly IMapper mapper;
    private readonly IMoneyCardsRepository _repository;
    private readonly MoneyRules _rules;

    public MoneyUpdateCommendHandler(IMapper mapper, IMoneyCardsRepository repository, MoneyRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<MoneyUpdateCommendRespons> Handle(MoneyUpdateCommendRequest request,
        CancellationToken cancellationToken)
    {
        MoneyCards? card = await _rules.IsThereACard(request.Id);

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
        if (request.Gain != null)
            card.Gain = request.Gain.Value;

        await _repository.UpdateAsync(card);
        return mapper.Map<MoneyUpdateCommendRespons>(card);
    }
}