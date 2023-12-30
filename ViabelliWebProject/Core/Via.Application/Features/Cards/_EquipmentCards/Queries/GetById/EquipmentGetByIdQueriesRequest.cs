using MediatR;

namespace Via.Application.Features.Cards._EquipmentCards.Queries.GetById;

public class EquipmentGetByIdQueriesRequest : IRequest<EquipmentGetByIdQueriesRespons>
{
    public Guid Id { get; set; }
}