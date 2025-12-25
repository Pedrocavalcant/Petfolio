using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetDto Execute()
    {
        return new ResponseAllPetDto
        {
            Pets = new List<ResponseShortPetDto>
            {
                new ResponseShortPetDto
                {
                    Id = 1,
                    Name = "Buddy",
                    Type = Communication.Enums.PetType.Dog
                }
            }
        };
    }
}
