using FluentValidation;
using Via.Application.Features.Denemes.Comments.Create;

namespace Via.Application.Features.Cards._EquipmentCards.Comments.Create;

public class EquipmentCreateCommendValid : AbstractValidator<EquipmentCreateCommendRequest>
{
    public EquipmentCreateCommendValid()
    {
        // RuleFor(i => i.Name).NotEmpty().NotNull().MinimumLength(4);
    }
}