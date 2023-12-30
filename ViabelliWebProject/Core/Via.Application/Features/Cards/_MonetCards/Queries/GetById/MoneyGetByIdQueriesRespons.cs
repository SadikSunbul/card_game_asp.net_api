namespace Via.Application.Features.Cards._MonetCards.Queries.GetById;

public class MoneyGetByIdQueriesRespons
{
    public Guid Id { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public int CopyCount { get; set; }
    public string PngUrl { get; set; }
    public int Gain { get; set; }
    public string Talk { get; set; }
}