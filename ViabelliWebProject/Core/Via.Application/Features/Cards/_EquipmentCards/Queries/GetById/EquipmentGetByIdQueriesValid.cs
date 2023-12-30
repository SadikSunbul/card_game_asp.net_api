using FluentValidation;
using Via.Application.Features.Cards._EquipmentCards.Comments.Update;

namespace Via.Application.Features.Cards._EquipmentCards.Queries.GetById;

public class EquipmentGetByIdQueriesValid : AbstractValidator<EquipmentUpdateCommendRequest>
{
    public EquipmentGetByIdQueriesValid()
    {
    }
}