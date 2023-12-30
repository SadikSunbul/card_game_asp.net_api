using AutoMapper;
using MediatR;
using Via.Application.Features.Cards._MonetCards.Rules;
using Via.Application.Features.Cards._PotionCards.Rules;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;

namespace Via.Application.Features.Cards._PotionCards.Comments.Create;

public class
    PotionCreateCommendHandler : IRequestHandler<PotionCreateCommendRequest, PotionCreateCommendRespons>
{
    private readonly IMapper mapper;
    private readonly IPotionCardsRepository _repository;
    private readonly PotionRules _rules;

    public PotionCreateCommendHandler(IMapper mapper, IPotionCardsRepository repository, PotionRules rules)
    {
        this.mapper = mapper;
        _repository = repository;
        _rules = rules;
    }

    public async Task<PotionCreateCommendRespons> Handle(PotionCreateCommendRequest request,
        CancellationToken cancellationToken)
    {
        PotionCards card = new PotionCards();
        card = mapper.Map<PotionCards>(request);
        await _repository.AddAsync(card);
        return mapper.Map<PotionCreateCommendRespons>(card);
    }
}