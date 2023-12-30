using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._MonetCards.Rules;
using Via.Application.Services.Repositories.Cards;

namespace Via.Application.Features.Cards._MonetCards.Queries.GetName;

public class
    MoneyGetByNameQueriesHandler : IRequestHandler<MoneyGetByNameQueriesRequest, MoneyGetByNameQueriesRespons>
{
    private readonly IMapper mapper;
    private readonly IMoneyCardsRepository _repository;
    private readonly MoneyRules _rules;

    public MoneyGetByNameQueriesHandler(IMapper mapper, IMoneyCardsRepository repository, MoneyRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<MoneyGetByNameQueriesRespons> Handle(MoneyGetByNameQueriesRequest request,
        CancellationToken cancellationToken)
    {
        var card = await _rules.IsThereACard(request.Name);
        return mapper.Map<MoneyGetByNameQueriesRespons>(card);
    }
}