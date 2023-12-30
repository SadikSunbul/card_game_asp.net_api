using FluentValidation;
using Via.Application.Features.Cards._EquipmentCards.Comments.Create;

namespace Via.Application.Features.Cards._EquipmentCards.Comments.Delete;

public class EquipmentDeleteCommendValid : AbstractValidator<EquipmentDeleteCommendRequest>
{
    public EquipmentDeleteCommendValid()
    {
    }
}