using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Via.Application.Features.Cards._EquipmentCards.Rules;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._EquipmentCards.Queries.GetList;

public class
    EquipmentGetlistQueriesHandler : IRequestHandler<EquipmentGetlistQueriesRequest,
        EquipmentGetlistQueriesRespons>
{
    private readonly IMapper mapper;

    public EquipmentGetlistQueriesHandler(IMapper mapper, IEquipmentCardsRepository repository,
        EquipmentRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    private readonly IEquipmentCardsRepository _repository;
    private readonly EquipmentRules _rules;

    public async Task<EquipmentGetlistQueriesRespons> Handle(EquipmentGetlistQueriesRequest request,
        CancellationToken cancellationToken)
    {
        List<EquipmentCards> cards = await _repository.Query().ToListAsync();
        return new EquipmentGetlistQueriesRespons() { Cards = cards };
    }
}