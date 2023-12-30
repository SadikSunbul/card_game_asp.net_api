using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._EquipmentCards.Rules;
using Via.Application.Services.Repositories.Cards;

namespace Via.Application.Features.Cards._EquipmentCards.Comments.Delete;

public class
    EquipmentDeleteCommendHandler : IRequestHandler<EquipmentDeleteCommendRequest,
        EquipmentDeleteCommendRespons>
{
    private readonly IMapper mapper;
    private readonly IEquipmentCardsRepository _repository;
    private readonly EquipmentRules _rules;

    public EquipmentDeleteCommendHandler(IMapper mapper, IEquipmentCardsRepository repository,
        EquipmentRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<EquipmentDeleteCommendRespons> Handle(EquipmentDeleteCommendRequest request,
        CancellationToken cancellationToken)
    {
        var card = await _rules.IsThereACard(request.Id);

        await _repository.DeleteAsync(card, permanent: true);

        return mapper.Map<EquipmentDeleteCommendRespons>(card);
    }
}