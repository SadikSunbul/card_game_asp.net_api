using ViabelliWebProject.Packages.Core.Persistance.Repositories;

namespace Via.Domain.Entities.CardGame;

public class Card:Entity<Guid>
{
    public string Type { get; set; }
    public string Name { get; set; }
    public int CopyCount { get; set; }
    public string PngUrl { get; set; }
}