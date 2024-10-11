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

    public bool EstaVivo()
    {
        return Health > 0;
    }
    
    public string Nombre { get; set; }
   	public double Ataque { get; set; }
    public double Health { get; set; } 
    public double Defense { get; set; }
    public List<IAtaque> Abilities { get; set; }
    public bool EstaDebilitado { get; private set; } = false;
    public class CalculadoraDaño
    {
        public static double CalcularDaño(double N, double A, double P, double D) 
        {
            double parte1 = (0.2 * 100 + 1) * A * P;
            double parte2 = parte1 / (25 * D);
            double daño = 0.01 * (parte2 + 2);
        
            return daño;
        }
    }
    public void Atacar(IPokemon enemigo, Ataque ataqueSeleccionado, double N)
    {
        double daño = CalculadoraDaño.CalcularDaño(N, Ataque + ataqueSeleccionado.Poder, ataqueSeleccionado.Poder,
            enemigo.Defensa);

        enemigo.Health -= daño;

        if (enemigo.Health <= 0)
        {
            enemigo.Health = 0;
            enemigo.EstaDebilitado = true;
        }
    }
    
}