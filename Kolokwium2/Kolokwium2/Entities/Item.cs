namespace Kolokwium2.Entities;

public class Item
{
    public int IdItem { get; set; }
    public string Name { get; set; }
    public int Weigth { get; set; }

    public virtual ICollection<Backpack> Backpacks { get; set; } = new List<Backpack>();
}