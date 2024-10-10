namespace Library.Interface;

public interface IPokemon
{
    public int Ataque { get; set; }
    public int Health { get; set; }
    public int Tipo { get; set; }
    
    public List<int> Abilities { get; set; }
}