
namespace Domain.Entities;

public class Room {
    public Guid Id { get; set; } = Guid.NewGuid();

    public int Number { get; set; }

    public int Floor { get; set; }

    public int Grade { get; set; }
}
