namespace Library.Interface;

public interface IPokemon
{
    public int Ataque { get; set; }
    public int Health { get; set; }
    
    public List<IAtaque> Abilities { get; set; }

    public void Atacar(IPokemon Pokemon);
    public void RecibirDaño(int Ataque);
    
}