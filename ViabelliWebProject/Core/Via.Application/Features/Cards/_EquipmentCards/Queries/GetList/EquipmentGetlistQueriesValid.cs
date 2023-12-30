using FluentValidation;
using Via.Application.Features.Cards._EquipmentCards.Queries.GetName;

namespace Via.Application.Features.Cards._EquipmentCards.Queries.GetList;

public class EquipmentGetlistQueriesValid : AbstractValidator<EquipmentGetlistQueriesRequest>
{
    public EquipmentGetlistQueriesValid()
    {
    }
}