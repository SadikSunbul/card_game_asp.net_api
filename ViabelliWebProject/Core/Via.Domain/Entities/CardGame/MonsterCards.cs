namespace Via.Domain.Entities.CardGame;

public class MonsterCards:Card
{
    public int Attack { get; set; }
    public int Health { get; set; }
    public int Shield { get; set; }
    public string? Bonus { get; set; }
    public string Talk { get; set; }
}