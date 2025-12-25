using Microsoft.AspNetCore.Mvc;
using Petfolio.Communication.Requests;

namespace Petfolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestRegisterPetDto dto)
    {
        return Created();
    }
}
