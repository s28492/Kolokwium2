using Kolokwium2.Context;
using Kolokwium2.DTO;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Repositories;

public class CharactersRepositories : ICharacterRepositories
{
    private readonly BackpackDbContext _backpackDbContext;

    public CharactersRepositories(BackpackDbContext backpackDbContext)
    {
        _backpackDbContext = backpackDbContext;
    }

    public async Task<CharactersDTO> GetCharacter(int characterId)
    {
        var character = await _backpackDbContext.Characters
            .Include(c => c.Backpacks).ThenInclude(x => x.Item)
            .Include(c => c.CharacterTitles).ThenInclude(q => q.Title)
            .FirstOrDefaultAsync(z => z.Id == characterId);

        if (character == null) return null;
        
        
        var result = new CharactersDTO
        {
            Id = character.Id,
            FirstName = character.FirstName,
            LastName = character.LastName,
            CurrentWei = character.CurrentWei,
            MaxWeigth = character.MaxWeigth,
            BackpackItemsDtos = character.Backpacks.Select(x=> new BackpackItemsDTO
            {
                Name = x.Item.Name,
                Weigth = x.Item.Weigth,
                Amount = x.Amount
            }).ToList(),
            
            TitlesDtos = character.CharacterTitles.Select(z=> new TitlesDTO
            {
                TitleId = z.TitleId,
                AcquiredAt = z.AcquiredAt
            }).ToList()
        };

        return result;
    }
}