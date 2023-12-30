namespace Via.Application.Features.Cards._EquipmentCards.Queries.GetName;

public class EquipmentGetByNameQueriesRespons
{
    public Guid Id { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public int CopyCount { get; set; }
    public string PngUrl { get; set; }
    public int Power { get; set; }
    public string? Bonus { get; set; }
    public int Cost { get; set; }
    public string Talk { get; set; }
}