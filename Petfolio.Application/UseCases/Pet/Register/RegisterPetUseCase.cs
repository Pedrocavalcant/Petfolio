using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Register;

public class RegisterPetUseCase
{
    public ResponseRegisteredPetDto Execute(RequestRegisterPetDto dto)
    {
        return new ResponseRegisteredPetDto
        {
            Id = 7,
            Name = dto.Name
        };
    }
}
