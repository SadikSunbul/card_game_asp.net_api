namespace Via.Application.Features.Cards._MonsterCards.Comments.Update;

public class MonsterUpdateCommendRespons
{
    public Guid Id { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public int CopyCount { get; set; }
    public string PngUrl { get; set; }
    public int Attack { get; set; }
    public int Health { get; set; }
    public int Shield { get; set; }
    public string? Bonus { get; set; }
    public string Talk { get; set; }
}