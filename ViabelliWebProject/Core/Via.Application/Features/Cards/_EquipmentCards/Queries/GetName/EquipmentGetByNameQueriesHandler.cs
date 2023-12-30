using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._EquipmentCards.Rules;
using Via.Application.Services.Repositories.Cards;

namespace Via.Application.Features.Cards._EquipmentCards.Queries.GetName;

public class EquipmentGetByNameQueriesHandler : IRequestHandler<EquipmentGetByNameQueriesRequest,
    EquipmentGetByNameQueriesRespons>
{
    private readonly IMapper mapper;
    private readonly IEquipmentCardsRepository _repository;
    private readonly EquipmentRules _rules;

    public EquipmentGetByNameQueriesHandler(IMapper mapper, IEquipmentCardsRepository repository,
        EquipmentRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<EquipmentGetByNameQueriesRespons> Handle(EquipmentGetByNameQueriesRequest request,
        CancellationToken cancellationToken)
    {
        var card = await _rules.IsThereACard(request.Name);
        return mapper.Map<EquipmentGetByNameQueriesRespons>(card);
    }
}