using MediatR;

namespace Via.Application.Features.Cards._EquipmentCards.Comments.Update;

public class EquipmentUpdateCommendRequest : IRequest<EquipmentUpdateCommendRespons>
{
    public Guid Id { get; set; }
    public string? Type { get; set; }
    public string? Name { get; set; }
    public int? CopyCount { get; set; }
    public string? PngUrl { get; set; }
    public int? Power { get; set; }
    public string? Bonus { get; set; }
    public int? Cost { get; set; }
    public string? Talk { get; set; }
}