using Kolokwium2.DTO;

namespace Kolokwium2.Repositories;

public interface ICharacterRepositories
{
    public Task<CharactersDTO> GetCharacter(int characterId);
}
