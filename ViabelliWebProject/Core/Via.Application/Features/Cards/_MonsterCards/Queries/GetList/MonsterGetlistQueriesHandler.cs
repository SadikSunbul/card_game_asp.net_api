using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Via.Application.Features.Cards._MonsterCards.Rules;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._MonsterCards.Queries.GetList;

public class
    MonsterGetlistQueriesHandler : IRequestHandler<MonsterGetlistQueriesRequest, MonsterGetlistQueriesRespons>
{
    private readonly IMapper mapper;
    private readonly IMonsterCardsRepository _repository;
    private readonly MonsterRules _rules;

    public MonsterGetlistQueriesHandler(IMapper mapper, IMonsterCardsRepository repository,
        MonsterRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<MonsterGetlistQueriesRespons> Handle(MonsterGetlistQueriesRequest request,
        CancellationToken cancellationToken)
    {
        List<MonsterCards> cards = await _repository.Query().ToListAsync();
        return new MonsterGetlistQueriesRespons() { Cards = cards };
    }
}