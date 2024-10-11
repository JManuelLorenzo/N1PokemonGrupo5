namespace Library.Interface;

public interface IPokemon
{
    public string Name { get; set; }
    public int Ataque { get; set; }
    public int Health { get; set; }
    public int Defense { get; set; }
    
    public List<IAtaque> Abilities { get; set; }
    public int GetHealth();
    public List<IAtaque> GetAbilities();
    public int GetAttack();
    public void Atacar(IPokemon Pokemon);
    public void RecibirDaño(int Ataque);
    public string GetName();
}