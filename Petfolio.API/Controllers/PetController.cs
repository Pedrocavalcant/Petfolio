using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.Delete;
using Petfolio.Application.UseCases.Pets.GetAll;
using Petfolio.Application.UseCases.Pets.GetById;
using Petfolio.Application.UseCases.Pets.Register;
using Petfolio.Application.UseCases.Pets.Update;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredPetDto),StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorDto),StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestPetDto dto)
    {
        var useCase = new RegisterPetUseCase();

        var response = useCase.Execute(dto);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseRegisteredPetDto),StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPetDto dto)
    {
        var useCase = new UpdatePetUseCase();

        useCase.Execute(id, dto);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<ResponseAllPetDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllPetsUseCase();

        var response = useCase.Execute();

        if(response.Pets.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponsePetDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseRegisteredPetDto), StatusCodes.Status404NotFound)]
    public IActionResult Get(int id)
    {
        var useCase = new GetPetByIdUseCase();

        var response = useCase.Execute(id);

        return Ok();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponsePetDto), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseRegisteredPetDto), StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        var useCase = new DeletePetByIdUseCase();

        useCase.Execute(id);

        return NoContent();
    }

}
