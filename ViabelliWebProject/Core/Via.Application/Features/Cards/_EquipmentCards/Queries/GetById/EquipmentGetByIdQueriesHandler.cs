using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._EquipmentCards.Rules;
using Via.Application.Services.Repositories.Cards;

namespace Via.Application.Features.Cards._EquipmentCards.Queries.GetById;

public class
    EquipmentGetByIdQueriesHandler : IRequestHandler<EquipmentGetByIdQueriesRequest,
        EquipmentGetByIdQueriesRespons>
{
    private readonly IMapper mapper;
    private readonly IEquipmentCardsRepository _repository;
    private readonly EquipmentRules _rules;

    public EquipmentGetByIdQueriesHandler(IMapper mapper, IEquipmentCardsRepository repository,
        EquipmentRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<EquipmentGetByIdQueriesRespons> Handle(EquipmentGetByIdQueriesRequest request,
        CancellationToken cancellationToken)
    {
        var card = await _rules.IsThereACard(request.Id);
        return mapper.Map<EquipmentGetByIdQueriesRespons>(card);
    }
}