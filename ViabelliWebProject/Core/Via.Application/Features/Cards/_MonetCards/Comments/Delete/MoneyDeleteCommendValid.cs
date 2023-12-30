using FluentValidation;
using Via.Application.Features.Cards._MonetCards.Comments.Create;
using Via.Application.Features.Cards._MonetCards.Comments.Update;

namespace Via.Application.Features.Cards._MonetCards.Comments.Delete;

public class MoneyDeleteCommendValid : AbstractValidator<MoneyDeleteCommendRequest>
{
    public MoneyDeleteCommendValid()
    {
    }
}