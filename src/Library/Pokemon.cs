using Library.Interface;

namespace Library;

public class Pokemon: IPokemon
{
    public Pokemon(int ataque, int health,int defense,List<IAtaque> Hablidades )
    {
        Ataque = ataque;
        Health = health;
        Defense = defense;
        Abilities = Hablidades;
    }

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