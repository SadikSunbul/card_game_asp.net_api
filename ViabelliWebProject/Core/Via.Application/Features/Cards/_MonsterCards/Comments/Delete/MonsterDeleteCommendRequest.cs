using MediatR;

namespace Via.Application.Features.Cards._MonsterCards.Comments.Delete;

public class MonsterDeleteCommendRequest : IRequest<MonsterDeleteCommendRespons>
{
    public Guid Id { get; set; }
}