namespace Kolokwium2.DTO;

public class CharactersDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CurrentWei { get; set; }
    public int MaxWeigth { get; set; }
    public List<BackpackItemsDTO> BackpackItemsDtos { get; set; } 
    public List<TitlesDTO> TitlesDtos { get; set; } 
}