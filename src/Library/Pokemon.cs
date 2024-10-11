using Library.Interface;

namespace Library;

public class Pokemon: IPokemon
{
    public Pokemon(string name,int ataque, int health,int defense,List<IAtaque> hablidades )
    {
        Name = name;
        Ataque = ataque;
        Health = health;
        Defense = defense;
        Abilities = hablidades;
    }
    public string Name { get; set; }
   	public int Ataque { get; set; }
    public int Health { get; set; } 
    public int Defense { get; set; }
    public List<IAtaque> Abilities { get; set; }
    

    public void RecibirDaño(int Ataque)
    {
        Health = Health - (Defense-Ataque);
    }
    public void Atacar(IPokemon Pokemon)
    {
        Pokemon.RecibirDaño(Ataque);
    }
    
}