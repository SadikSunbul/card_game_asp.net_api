using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._PotionCards.Queries.GetById;
using Via.Application.Features.Cards._PotionCards.Rules;
using Via.Application.Services.Repositories.Cards;

namespace Via.Application.Features.Cards._PotionCards.Queries.GetByName;

public class
    PotionGetByNameQueriesHandler : IRequestHandler<PotionGetByNameQueriesRequest,
        PotionGetByNameQueriesRespons>
{
    private readonly IMapper mapper;
    private readonly IPotionCardsRepository _repository;
    private readonly PotionRules _rules;

    public PotionGetByNameQueriesHandler(IMapper mapper, IPotionCardsRepository repository, PotionRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<PotionGetByNameQueriesRespons> Handle(PotionGetByNameQueriesRequest request,
        CancellationToken cancellationToken)
    {
        var card = await _rules.IsThereACard(request.Name);
        return mapper.Map<PotionGetByNameQueriesRespons>(card);
    }
}