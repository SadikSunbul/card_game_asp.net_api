using MediatR;

namespace Via.Application.Features.Cards._MonetCards.Queries.GetName;

public class MoneyGetByNameQueriesRequest:IRequest<MoneyGetByNameQueriesRespons>
{
    public string Name { get; set; }
}