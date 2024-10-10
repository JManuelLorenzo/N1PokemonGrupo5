using Library.Interface;

namespace Library;

public class Pokemon: IPokemon
{
    public Pokemon(int ataque, int health, int tipo,List<int> Hablidades )
    {
        Ataque = ataque;
        Health = health;
        Tipo = tipo;
        Ablities.Add(ListaAtaques);
        
        
    }

   	public int Ataque { get; set; }
    public int Health { get; set; }
    public int Tipo { get; set; }
    
    public List<IAtaque> Ablities { get; set; }
}