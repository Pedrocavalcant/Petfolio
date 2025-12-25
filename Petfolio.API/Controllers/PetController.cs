using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pet.Register;
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
        var useCase = new RegisterPetUseCase();

        var response = useCase.Execute(dto);

        return Created(string.Empty, response);
    }
}
