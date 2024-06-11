namespace Kolokwium2.Entities;

public class Title
{
    public int IdTitle { get; set; } 
    public string Name { get; set; }

    public virtual ICollection<CharacterTitle> CharacterTitles { get; set; } = new List<CharacterTitle>();
}