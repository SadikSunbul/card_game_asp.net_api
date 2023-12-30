using MediatR;

namespace Via.Application.Features.Cards._MonsterCards.Queries.GetName;

public class MonsterGetByNameQueriesRequest:IRequest<MonsterGetByNameQueriesRespons>
{
    public string Name { get; set; }
}