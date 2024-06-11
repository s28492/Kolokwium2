using Kolokwium2.DTO;
using Kolokwium2.Repositories;

namespace Kolokwium2.Services;

public class CharacterService: ICharacterService
{
    private readonly ICharacterRepositories _characterRepositories;

    public CharacterService(ICharacterRepositories characterRepositories)
    {
        _characterRepositories = characterRepositories;
    }

    public Task<CharactersDTO> GetCharacter(int characterID)
    {
        return _characterRepositories.GetCharacter(characterID);
    }
}