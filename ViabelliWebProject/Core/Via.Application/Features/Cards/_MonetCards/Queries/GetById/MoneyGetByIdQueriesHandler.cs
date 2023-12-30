using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._EquipmentCards.Rules;
using Via.Application.Features.Cards._MonetCards.Rules;
using Via.Application.Services.Repositories.Cards;

namespace Via.Application.Features.Cards._MonetCards.Queries.GetById;

public class
    MoneyGetByIdQueriesHandler : IRequestHandler<MoneyGetByIdQueriesReques, MoneyGetByIdQueriesRespons>
{
    private readonly IMapper mapper;
    private readonly IMoneyCardsRepository _repository;
    private readonly MoneyRules _rules;

    public MoneyGetByIdQueriesHandler(IMapper mapper, IMoneyCardsRepository repository, MoneyRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<MoneyGetByIdQueriesRespons> Handle(MoneyGetByIdQueriesReques request,
        CancellationToken cancellationToken)
    {
        var card = await _rules.IsThereACard(request.Id);
        return mapper.Map<MoneyGetByIdQueriesRespons>(card);
    }
}