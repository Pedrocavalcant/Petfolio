using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetDto Execute(int id)
    {
        return new ResponsePetDto
        {
            Id = id,
            Name = "Teste",
            Type = Communication.Enums.PetType.Cat,
            Birthday = new DateTime(year: 2024, month: 12, day: 30)
        };
    }
}
