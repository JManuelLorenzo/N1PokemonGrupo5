namespace Library.Interface;

public interface IPokemon
{
    public string Nombre { get; set; }
    public double Ataque { get; set; }
    public double Defensa { get; set; }
    public double Health { get; set; }
    public bool EstaDebilitado { get; private set; } = false;

    public List<IAtaque> Abilities { get; set; }

    public void Atacar(IPokemon Pokemon);
    
}