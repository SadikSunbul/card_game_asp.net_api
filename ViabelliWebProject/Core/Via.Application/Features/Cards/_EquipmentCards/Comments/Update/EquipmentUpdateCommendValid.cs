using FluentValidation;
using Via.Application.Features.Cards._EquipmentCards.Comments.Create;

namespace Via.Application.Features.Cards._EquipmentCards.Comments.Update;

public class EquipmentUpdateCommendValid : AbstractValidator<EquipmentUpdateCommendRequest>
{
    public EquipmentUpdateCommendValid()
    {
    }
}