using MediatR;

namespace Via.Application.Features.Cards._MonetCards.Comments.Delete;

public class MoneyDeleteCommendRequest : IRequest<MoneyDeleteCommendRespons>
{
    public Guid Id { get; set; }
}