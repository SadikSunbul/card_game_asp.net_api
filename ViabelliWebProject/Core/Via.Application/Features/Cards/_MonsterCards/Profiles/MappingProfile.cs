using AutoMapper;
using Via.Application.Features.Cards._MonsterCards.Comments.Create;
using Via.Application.Features.Cards._MonsterCards.Comments.Delete;
using Via.Application.Features.Cards._MonsterCards.Comments.Update;
using Via.Application.Features.Cards._MonsterCards.Queries.GetById;
using Via.Application.Features.Cards._MonsterCards.Queries.GetName;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._MonsterCards.Profiles;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<MonsterCreateCommendRespons,MonsterCards>().ReverseMap();
        CreateMap<MonsterCreateCommendRequest,MonsterCards>().ReverseMap();
        
        CreateMap<MonsterUpdateCommendRespons, MonsterCards>().ReverseMap();
        CreateMap<MonsterCards, MonsterDeleteCommendRespons>().ReverseMap();
        CreateMap<MonsterGetByIdQueriesRespons, MonsterCards>().ReverseMap();
        CreateMap<MonsterGetByNameQueriesRespons, MonsterCards>().ReverseMap();
    }
}