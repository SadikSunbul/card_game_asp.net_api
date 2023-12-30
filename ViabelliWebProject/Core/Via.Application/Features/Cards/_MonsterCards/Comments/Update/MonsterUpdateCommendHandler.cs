using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._MonsterCards.Rules;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._MonsterCards.Comments.Update;

public class
    MonsterUpdateCommendHandler : IRequestHandler<MonsterUpdateCommendRequest, MonsterUpdateCommendRespons>
{
    private readonly IMapper mapper;
    private readonly IMonsterCardsRepository _repository;
    private readonly MonsterRules _rules;

    public MonsterUpdateCommendHandler(IMapper mapper, IMonsterCardsRepository repository, MonsterRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }


    public async Task<MonsterUpdateCommendRespons> Handle(MonsterUpdateCommendRequest request,
        CancellationToken cancellationToken)
    {
        MonsterCards? card = await _rules.IsThereACard(request.Id);

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
        if (request.Attack != null)
            card.Attack = request.Attack.Value;
        if (request.Health != null)
            card.Health = request.Health.Value;
        if (request.Shield != null)
            card.Shield = request.Shield.Value;
        if (request.Bonus != null)
            card.Bonus = request.Bonus;
        
        await _repository.UpdateAsync(card);
        return mapper.Map<MonsterUpdateCommendRespons>(card);
    }
}