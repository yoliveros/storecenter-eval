namespace Application.DTOs;

public class ReservationDTO
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = string.Empty;

    public string Room { get; set; } = string.Empty;
}
