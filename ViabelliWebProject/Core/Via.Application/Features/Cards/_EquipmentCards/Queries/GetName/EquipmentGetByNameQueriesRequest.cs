using MediatR;

namespace Via.Application.Features.Cards._EquipmentCards.Queries.GetName;

public class EquipmentGetByNameQueriesRequest : IRequest<EquipmentGetByNameQueriesRespons>
{
    public string Name { get; set; }
}