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

    public int GetHealth()
    {
        return Health;
    }
    public void RecibirDaño(int ataque)
    {
        if (ataque > Health)
        {
            Health = 0;
        }
        else
        {
            Health = Health - ataque;
        }
    }


    public void Atacar(IPokemon pokemonEnemigo)
    {
        pokemonEnemigo.RecibirDaño(Ataque);
    }

    public List<IAtaque> GetAbilities()
    {
        return Abilities;
    }

    public int GetAttack()
    {
        return Ataque;
    }

    public string GetName()
    {
        return Name;
    }

    public int GetDefense()
    {
        return Defense;
    }
}