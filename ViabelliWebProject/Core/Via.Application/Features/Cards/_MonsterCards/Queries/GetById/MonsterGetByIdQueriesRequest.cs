using MediatR;

namespace Via.Application.Features.Cards._MonsterCards.Queries.GetById;

public class MonsterGetByIdQueriesRequest : IRequest<MonsterGetByIdQueriesRespons>
{
    public Guid Id { get; set; }
}