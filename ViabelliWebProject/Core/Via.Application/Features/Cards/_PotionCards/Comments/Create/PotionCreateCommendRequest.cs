using MediatR;

namespace Via.Application.Features.Cards._PotionCards.Comments.Create;

public class PotionCreateCommendRequest:IRequest<PotionCreateCommendRespons>
{ 
    public string Type { get; set; }
    public string Name { get; set; }
    public int CopyCount { get; set; }
    public string PngUrl { get; set; }
    public int HealthGain { get; set; }
    public int MoneyGain { get; set; }
    public string? Bonus { get; set; }
    public string Talk { get; set; }
    
}