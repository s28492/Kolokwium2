namespace Kolokwium2.Entities;

public class Character
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CurrentWei { get; set; }
    public int MaxWeigth { get; set; }
    
    public virtual ICollection<Backpack> Backpacks { get; set; } = new List<Backpack>();
    public virtual ICollection<CharacterTitle> CharacterTitles { get; set; } = new List<CharacterTitle>();
}

