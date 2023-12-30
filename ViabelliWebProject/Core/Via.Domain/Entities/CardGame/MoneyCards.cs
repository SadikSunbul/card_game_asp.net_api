using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Via.Domain.Entities.CardGame;

public class MoneyCards : Card
{
    public int Gain { get; set; }
    public string Talk { get; set; }
}