using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._MonetCards.Rules;
using Via.Application.Features.Cards._MonsterCards.Rules;
using Via.Application.Services.Repositories.Cards;

namespace Via.Application.Features.Cards._MonsterCards.Queries.GetName;

public class
    MonsterGetByNameQueriesHandler : IRequestHandler<MonsterGetByNameQueriesRequest,
        MonsterGetByNameQueriesRespons>
{
    private readonly IMapper mapper;
    private readonly IMonsterCardsRepository _repository;
    private readonly MonsterRules _rules;

    public MonsterGetByNameQueriesHandler(IMapper mapper, IMonsterCardsRepository repository,
        MonsterRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<MonsterGetByNameQueriesRespons> Handle(MonsterGetByNameQueriesRequest request,
        CancellationToken cancellationToken)
    {
        var card = await _rules.IsThereACard(request.Name);
        return mapper.Map<MonsterGetByNameQueriesRespons>(card);
    }
}