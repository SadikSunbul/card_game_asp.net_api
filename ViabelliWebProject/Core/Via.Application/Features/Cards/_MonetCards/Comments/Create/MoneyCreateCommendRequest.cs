using MediatR;

namespace Via.Application.Features.Cards._MonetCards.Comments.Create;

public class MoneyCreateCommendRequest : IRequest<MoneyCreateCommendRespons>
{
    public string Type { get; set; }
    public string Name { get; set; }
    public int CopyCount { get; set; }
    public string PngUrl { get; set; }
    public int Gain { get; set; }
    public string Talk { get; set; }
    
}