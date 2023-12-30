using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._PotionCards.Rules;
using Via.Application.Services.Repositories.Cards;

namespace Via.Application.Features.Cards._PotionCards.Queries.GetById;

public class
    PotionGetByIdQueriesHandler : IRequestHandler<PotionGetByIdQueriesRequest, PotionGetByIdQueriesRespons>
{
    private readonly IMapper mapper;
    private readonly IPotionCardsRepository _repository;
    private readonly PotionRules _rules;

    public PotionGetByIdQueriesHandler(IMapper mapper, IPotionCardsRepository repository, PotionRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<PotionGetByIdQueriesRespons> Handle(PotionGetByIdQueriesRequest request,
        CancellationToken cancellationToken)
    {
        var card = await _rules.IsThereACard(request.Id);
        return mapper.Map<PotionGetByIdQueriesRespons>(card);
    }
}