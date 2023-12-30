using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._PotionCards.Rules;
using Via.Application.Services.Repositories.Cards;

namespace Via.Application.Features.Cards._PotionCards.Comments.Delete;

public class PotionDeletCommendHandler : IRequestHandler<PotionDeletCommendRequest, PotionDeletCommendRespons>
{
    private readonly IMapper mapper;
    private readonly IPotionCardsRepository _repository;
    private readonly PotionRules _rules;

    public PotionDeletCommendHandler(IMapper mapper, IPotionCardsRepository repository, PotionRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<PotionDeletCommendRespons> Handle(PotionDeletCommendRequest request,
        CancellationToken cancellationToken)
    {
        var card = await _rules.IsThereACard(request.Id);

        await _repository.DeleteAsync(card, permanent: true);

        return mapper.Map<PotionDeletCommendRespons>(card);
    }
}