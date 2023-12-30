using MediatR;

namespace Via.Application.Features.Cards._PotionCards.Comments.Delete;

public class PotionDeletCommendRequest : IRequest<PotionDeletCommendRespons>
{
    public Guid Id { get; set; }
}