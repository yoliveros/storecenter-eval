
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservationController : ControllerBase
{
  [HttpGet]
  public ActionResult<string> GetAvailables()
  {
    return Ok("Prueba");
  }
}
