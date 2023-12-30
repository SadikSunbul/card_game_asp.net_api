using AutoMapper;
using Via.Application.Features.Cards._MonetCards.Comments.Create;
using Via.Application.Features.Cards._MonetCards.Comments.Delete;
using Via.Application.Features.Cards._MonetCards.Comments.Update;
using Via.Application.Features.Cards._MonetCards.Queries.GetById;
using Via.Application.Features.Cards._MonetCards.Queries.GetName;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._MonetCards.Profiles;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<MoneyCreateCommendRespons,MoneyCards>().ReverseMap();
        CreateMap<MoneyCreateCommendRequest,MoneyCards>().ReverseMap();
        
        CreateMap<MoneyUpdateCommendRespons, MoneyCards>().ReverseMap();
        CreateMap<MoneyCards, MoneyDeleteCommendRespons>().ReverseMap();
        CreateMap<MoneyGetByIdQueriesRespons, MoneyCards>().ReverseMap();
        CreateMap<MoneyGetByNameQueriesRespons, MoneyCards>().ReverseMap();
        
    }
}