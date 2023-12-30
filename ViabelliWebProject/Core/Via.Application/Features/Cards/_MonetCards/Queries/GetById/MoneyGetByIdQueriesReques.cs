using MediatR;

namespace Via.Application.Features.Cards._MonetCards.Queries.GetById;

public class MoneyGetByIdQueriesReques : IRequest<MoneyGetByIdQueriesRespons>
{
    public Guid Id { get; set; }
}