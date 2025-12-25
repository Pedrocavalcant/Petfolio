using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;

public class ResponseShortPetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PetType Type { get; set; }
}
