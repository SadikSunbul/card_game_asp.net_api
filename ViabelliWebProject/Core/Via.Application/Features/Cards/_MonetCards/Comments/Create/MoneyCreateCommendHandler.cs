using AutoMapper;
using MediatR;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._MonetCards.Comments.Create;

public class MoneyCreateCommendHandler : IRequestHandler<MoneyCreateCommendRequest, MoneyCreateCommendRespons>
{
    private readonly IMapper mapper;
    private readonly IMoneyCardsRepository _repository;

    public MoneyCreateCommendHandler(IMapper mapper, IMoneyCardsRepository repository)
    {
        this.mapper = mapper;
        _repository = repository;
    }

    public async Task<MoneyCreateCommendRespons> Handle(MoneyCreateCommendRequest request,
        CancellationToken cancellationToken)
    {
        MoneyCards card = new MoneyCards();
        card = mapper.Map<MoneyCards>(request);
        await _repository.AddAsync(card);
        return mapper.Map<MoneyCreateCommendRespons>(card);
    }
}