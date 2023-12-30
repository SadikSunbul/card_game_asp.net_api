using MediatR;

namespace Via.Application.Features.Cards._PotionCards.Queries.GetByName;

public class PotionGetByNameQueriesRequest:IRequest<PotionGetByNameQueriesRespons>
{
    public string Name { get; set; }
}