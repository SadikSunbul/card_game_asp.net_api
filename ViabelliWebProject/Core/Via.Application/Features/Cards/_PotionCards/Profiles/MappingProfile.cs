using AutoMapper;
using Via.Application.Features.Cards._PotionCards.Comments.Create;
using Via.Application.Features.Cards._PotionCards.Comments.Delete;
using Via.Application.Features.Cards._PotionCards.Comments.Update;
using Via.Application.Features.Cards._PotionCards.Queries.GetById;
using Via.Application.Features.Cards._PotionCards.Queries.GetByName;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._PotionCards.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<PotionCreateCommendRespons, PotionCards>().ReverseMap();
        CreateMap<PotionCreateCommendRequest, PotionCards>().ReverseMap();

        CreateMap<PotionUpdateCommendRespons, PotionCards>().ReverseMap();
        CreateMap<PotionCards, PotionDeletCommendRespons>().ReverseMap();
        CreateMap<PotionGetByIdQueriesRespons, PotionCards>().ReverseMap();
        CreateMap<PotionGetByNameQueriesRespons, PotionCards>().ReverseMap();
    }
}