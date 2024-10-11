using Library.Interface;

namespace Library;

public class Pokemon: IPokemon
{
    public Pokemon(int ataque, int health,List<IAtaque> Hablidades )
    {
        Ataque = ataque;
        Health = health;
        Abilities = Hablidades;
        
        
    }

   	public int Ataque { get; set; }
    public int Health { get; set; } 
    public List<IAtaque> Abilities { get; set; }
}