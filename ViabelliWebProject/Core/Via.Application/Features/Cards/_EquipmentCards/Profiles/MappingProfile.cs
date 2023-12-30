using AutoMapper;
using Via.Application.Features.Cards._EquipmentCards.Comments.Create;
using Via.Application.Features.Cards._EquipmentCards.Comments.Delete;
using Via.Application.Features.Cards._EquipmentCards.Comments.Update;
using Via.Application.Features.Cards._EquipmentCards.Queries.GetById;
using Via.Application.Features.Cards._EquipmentCards.Queries.GetName;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._EquipmentCards.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<EquipmentCreateCommendRespons, EquipmentCards>().ReverseMap();
        CreateMap<EquipmentCreateCommendRequest, EquipmentCards>().ReverseMap();

        CreateMap<EquipmentUpdateCommendRespons, EquipmentCards>().ReverseMap();
        CreateMap<EquipmentCards, EquipmentDeleteCommendRespons>().ReverseMap();
        CreateMap<EquipmentGetByIdQueriesRespons, EquipmentCards>().ReverseMap();
        CreateMap<EquipmentGetByNameQueriesRespons, EquipmentCards>().ReverseMap();
    }
}