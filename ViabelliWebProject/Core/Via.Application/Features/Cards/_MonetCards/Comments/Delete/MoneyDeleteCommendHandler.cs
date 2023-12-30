using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._EquipmentCards.Comments.Delete;
using Via.Application.Features.Cards._MonetCards.Rules;
using Via.Application.Services.Repositories.Cards;

namespace Via.Application.Features.Cards._MonetCards.Comments.Delete;

public class MoneyDeleteCommendHandler : IRequestHandler<MoneyDeleteCommendRequest, MoneyDeleteCommendRespons>
{
    private readonly IMapper mapper;
    private readonly IMoneyCardsRepository _repository;
    private readonly MoneyRules _rules;

    public MoneyDeleteCommendHandler(IMapper mapper, IMoneyCardsRepository repository, MoneyRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<MoneyDeleteCommendRespons> Handle(MoneyDeleteCommendRequest request,
        CancellationToken cancellationToken)
    {
        var card = await _rules.IsThereACard(request.Id);

        await _repository.DeleteAsync(card, permanent: true);

        return mapper.Map<MoneyDeleteCommendRespons>(card);
    }
}