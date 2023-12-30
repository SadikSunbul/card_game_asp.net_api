using FluentValidation;
using Via.Application.Features.Cards._EquipmentCards.Comments.Create;

namespace Via.Application.Features.Cards._MonetCards.Comments.Create;

public class MoneyCreateCommendValid : AbstractValidator<MoneyCreateCommendRequest>
{
    public MoneyCreateCommendValid()
    {
    }
}