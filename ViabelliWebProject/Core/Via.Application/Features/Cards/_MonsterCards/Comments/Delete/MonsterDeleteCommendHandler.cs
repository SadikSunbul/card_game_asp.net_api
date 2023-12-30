using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._MonsterCards.Rules;
using Via.Application.Services.Repositories.Cards;

namespace Via.Application.Features.Cards._MonsterCards.Comments.Delete;

public class
    MonsterDeleteCommendHandler : IRequestHandler<MonsterDeleteCommendRequest, MonsterDeleteCommendRespons>
{
    private readonly IMapper mapper;
    private readonly IMonsterCardsRepository _repository;
    private readonly MonsterRules _rules;

    public MonsterDeleteCommendHandler(IMapper mapper, IMonsterCardsRepository repository, MonsterRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<MonsterDeleteCommendRespons> Handle(MonsterDeleteCommendRequest request,
        CancellationToken cancellationToken)
    {
        var card = await _rules.IsThereACard(request.Id);

        await _repository.DeleteAsync(card, permanent: true);

        return mapper.Map<MonsterDeleteCommendRespons>(card);
    }
}