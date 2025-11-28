using Domain.Entities;
using Application.DTOs;
using Microsoft.Extensions.DependencyInjection;
using Application.Services;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg =>
        {
            cfg.CreateMap<Reservation, ReservationDTO>();
            cfg.CreateMap<Room, RoomDTOs>();
        });

        services.AddScoped<IReservationService, ReservationService>();

        return services;
    }
}
