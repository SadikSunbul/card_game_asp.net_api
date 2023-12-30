using FluentValidation;
using Via.Application.Features.Cards._MonetCards.Comments.Create;

namespace Via.Application.Features.Cards._MonetCards.Comments.Update;

public class MoneyUpdateCommendValid : AbstractValidator<MoneyUpdateCommendRequest>
{
    public MoneyUpdateCommendValid()
    {
    }
}