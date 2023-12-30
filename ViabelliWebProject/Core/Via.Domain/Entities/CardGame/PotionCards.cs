namespace Via.Domain.Entities.CardGame;

public class PotionCards:Card
{
    public int HealthGain { get; set; }
    public int MoneyGain { get; set; }
    public string? Bonus { get; set; }
    public string Talk { get; set; }
}