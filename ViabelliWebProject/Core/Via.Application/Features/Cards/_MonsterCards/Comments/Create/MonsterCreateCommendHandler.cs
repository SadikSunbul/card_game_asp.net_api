using AutoMapper;
using MediatR;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._MonsterCards.Comments.Create;

public class MonsterCreateCommendHandler:IRequestHandler<MonsterCreateCommendRequest,MonsterCreateCommendRespons>
{
    private readonly IMapper mapper;
    private readonly IMonsterCardsRepository _repository;

    public MonsterCreateCommendHandler(IMapper mapper, IMonsterCardsRepository repository)
    {
        this.mapper = mapper;
        _repository = repository;
    }

    public async Task<MonsterCreateCommendRespons> Handle(MonsterCreateCommendRequest request, CancellationToken cancellationToken)
    {
        MonsterCards card = new MonsterCards();
        card = mapper.Map<MonsterCards>(request);
        await _repository.AddAsync(card);
        return mapper.Map<MonsterCreateCommendRespons>(card);
    }
}