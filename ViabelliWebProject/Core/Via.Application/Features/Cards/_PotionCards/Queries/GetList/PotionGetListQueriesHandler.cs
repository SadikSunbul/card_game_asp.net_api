using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Via.Application.Features.Cards._MonsterCards.Queries.GetList;
using Via.Application.Features.Cards._PotionCards.Rules;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._PotionCards.Queries.GetList;

public class
    PotionGetListQueriesHandler : IRequestHandler<PotionGetListQueriesRequest, PotionGetListQueriesRespons>
{
    private readonly IMapper mapper;
    private readonly IPotionCardsRepository _repository;
    private readonly PotionRules _rules;

    public PotionGetListQueriesHandler(IMapper mapper, IPotionCardsRepository repository, PotionRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<PotionGetListQueriesRespons> Handle(PotionGetListQueriesRequest request,
        CancellationToken cancellationToken)
    {
        List<PotionCards> cards = await _repository.Query().ToListAsync();
        return new PotionGetListQueriesRespons() { Cards = cards };
    }
}