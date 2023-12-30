using AutoMapper;
using MediatR;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._EquipmentCards.Comments.Create;

public class EquipmentCreateCommendHandler:IRequestHandler<EquipmentCreateCommendRequest,EquipmentCreateCommendRespons>
{
    public EquipmentCreateCommendHandler(IMapper mapper, IEquipmentCardsRepository repository)
    {
        this.mapper = mapper;
        _repository = repository;
    }

    private readonly IMapper mapper;
    private readonly IEquipmentCardsRepository _repository;
    
    public async Task<EquipmentCreateCommendRespons> Handle(EquipmentCreateCommendRequest request, CancellationToken cancellationToken)
    {
        EquipmentCards card = new EquipmentCards();
        card = mapper.Map<EquipmentCards>(request);
        await _repository.AddAsync(card);
        return mapper.Map<EquipmentCreateCommendRespons>(card);
    }
}