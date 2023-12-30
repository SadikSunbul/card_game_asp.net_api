using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._MonsterCards.Rules;
using Via.Application.Services.Repositories.Cards;

namespace Via.Application.Features.Cards._MonsterCards.Queries.GetById;

public class
    MonsterGetByIdQueriesHandler : IRequestHandler<MonsterGetByIdQueriesRequest, MonsterGetByIdQueriesRespons>
{
    private readonly IMapper mapper;
    private readonly IMonsterCardsRepository _repository;
    private readonly MonsterRules _rules;

    public MonsterGetByIdQueriesHandler(IMapper mapper, IMonsterCardsRepository repository,
        MonsterRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<MonsterGetByIdQueriesRespons> Handle(MonsterGetByIdQueriesRequest request,
        CancellationToken cancellationToken)
    {
        var card = await _rules.IsThereACard(request.Id);
        return mapper.Map<MonsterGetByIdQueriesRespons>(card);
    }
}