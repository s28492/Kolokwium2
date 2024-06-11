using Kolokwium2.DTO;
using Kolokwium2.Entities;

namespace Kolokwium2.Services;

public interface ICharacterService
{
    public Task<CharactersDTO> GetCharacter(int characterID);
}