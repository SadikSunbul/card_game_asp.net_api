using MediatR;

namespace Via.Application.Features.Cards._PotionCards.Queries.GetById;

public class PotionGetByIdQueriesRequest:IRequest<PotionGetByIdQueriesRespons>
{
    public Guid Id { get; set; }
}