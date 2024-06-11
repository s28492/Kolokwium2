using Kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

[Route("api/characters/[controller]")]
[ApiController]
public class CharactersController : ControllerBase
{
    private readonly ICharacterService _characterService;

    public CharactersController(ICharacterService characterService)
    {
        _characterService = characterService;
    }
    [HttpGet("{characterID:int}")]
    public async Task<IActionResult> GetCharacter(int characterID)
    {
        var character = await _characterService.GetCharacter(characterID);
        if (character == null) return NotFound("Not Found");
        return Ok(character);
    }
}   
