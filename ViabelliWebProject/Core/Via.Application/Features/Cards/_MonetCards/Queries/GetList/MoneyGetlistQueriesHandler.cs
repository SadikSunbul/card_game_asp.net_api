using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Via.Application.Features.Cards._EquipmentCards.Queries.GetList;
using Via.Application.Features.Cards._MonetCards.Rules;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._MonetCards.Queries.GetList;

public class
    MoneyGetlistQueriesHandler : IRequestHandler<MoneyGetlistQueriesRequest, MoneyGetlistQueriesRespons>
{
    private readonly IMapper mapper;
    private readonly IMoneyCardsRepository _repository;
    private readonly MoneyRules _rules;

    public MoneyGetlistQueriesHandler(IMapper mapper, IMoneyCardsRepository repository, MoneyRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<MoneyGetlistQueriesRespons> Handle(MoneyGetlistQueriesRequest request,
        CancellationToken cancellationToken)
    {
        List<MoneyCards> cards = await _repository.Query().ToListAsync();
        return new MoneyGetlistQueriesRespons() { Cards = cards };
    }
}