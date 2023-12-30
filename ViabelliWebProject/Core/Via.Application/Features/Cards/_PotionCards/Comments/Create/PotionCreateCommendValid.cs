using FluentValidation;
using Via.Application.Features.Cards._MonetCards.Comments.Delete;

namespace Via.Application.Features.Cards._PotionCards.Comments.Create;

public class PotionCreateCommendValid : AbstractValidator<PotionCreateCommendRequest>
{
    public PotionCreateCommendValid()
    {
    }
}