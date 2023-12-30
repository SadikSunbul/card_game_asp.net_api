using MediatR;

namespace Via.Application.Features.Cards._EquipmentCards.Comments.Delete;

public class EquipmentDeleteCommendRequest : IRequest<EquipmentDeleteCommendRespons>
{
    public Guid Id { get; set; }
}