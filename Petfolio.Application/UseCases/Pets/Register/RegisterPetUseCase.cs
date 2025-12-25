using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.Register;

public class RegisterPetUseCase
{
    public ResponseRegisteredPetDto Execute(RequestPetDto dto)
    {
        return new ResponseRegisteredPetDto
        {
            Id = 7,
            Name = dto.Name
        };
    }
}
