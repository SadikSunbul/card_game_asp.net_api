using FluentValidation;
using Via.Application.Features.Cards._EquipmentCards.Comments.Update;
using Via.Application.Features.Cards._EquipmentCards.Queries.GetById;

namespace Via.Application.Features.Cards._EquipmentCards.Queries.GetName;

public class EquipmentGetByNameQueriesValid : AbstractValidator<EquipmentGetByNameQueriesRequest>
{
    public EquipmentGetByNameQueriesValid()
    {
    }
}