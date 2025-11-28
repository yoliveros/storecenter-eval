
using Application.DTOs;

namespace Application.Services;

public interface IReservationService
{
    void Availables();
    void MakeReservation(ReservationDTO reservation);
    void CheckReservation(string id);
}
