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
        int dañoReal = Math.Max(0, ataque - Defense); // El daño no puede ser menor que 0
        Health -= dañoReal;

        if (Health < 0)
            Health = 0;

        Console.WriteLine($"{Name} recibió {dañoReal} de daño y ahora tiene {Health} de vida.");
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