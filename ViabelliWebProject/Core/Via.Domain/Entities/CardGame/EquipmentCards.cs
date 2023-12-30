namespace Via.Domain.Entities.CardGame;

public class EquipmentCards:Card
{
    public int Power { get; set; }
    public string? Bonus { get; set; }
    public int Cost { get; set; }
    public string Talk { get; set; }
}