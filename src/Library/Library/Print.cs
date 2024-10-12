namespace Library;

public class Print
{
    PokemonsYHablidades pokemonsYHablidades = new PokemonsYHablidades();
    
    public void parteDeArriba()
    {
        Console.WriteLine( "╔═════════════════════════════════════════╗");

    }

    public void parteDeAbajo()
    {
        Console.WriteLine("╚═════════════════════════════════════════╝");

    }

    public void startPrint()
    {
        Console.Clear();
        Console.WriteLine("╔═════════════════════╗");
        Console.WriteLine("║       POKEMON       ║");
        Console.WriteLine("╠═════════════════════╣");
        Console.WriteLine("║ 1) Iniciar          ║");
        Console.WriteLine("║ 2) Salir            ║");
        Console.WriteLine("╚═════════════════════╝");
    }

    public void endPrint()
    {
        Console.Clear();
        Console.WriteLine("╔══════════════════════╗");
        Console.WriteLine("║  Nos vemos pronto!   ║");
        Console.WriteLine("╚══════════════════════╝");
    }

    public void finDelJuego()
    {
        Console.Clear();
        Console.WriteLine("╔══════════════════════════╗");
        Console.WriteLine("║  El juego ha terminado!  ║");
        Console.WriteLine("╚══════════════════════════╝");
    }

    public void playerName(int num)
    {
        Console.WriteLine( "╔═════════════════════════════════════════╗");
        Console.WriteLine($"║ Ingrese el nombre del Jugador {num}:        ║");
        Console.WriteLine( "╚═════════════════════════════════════════╝");
    }
    public void selectSign()
    {
        Console.WriteLine("╔═════════════════════════════════════════╗");
        Console.WriteLine("║        Selecciona sus pokemons!         ║");
        Console.WriteLine("╚═════════════════════════════════════════╝");
    }

    public void tuEquipoSign()
    {
        Console.WriteLine("╔═════════════════════════════════════════╗");
        Console.WriteLine("║           Este es tu equipo!            ║");
        Console.WriteLine("╚═════════════════════════════════════════╝");
    }
    public void printMyTeam(string llave1, string llave2) //$"Numero: {item.Key}, Nombre: {item.Value.Name}");
    {
        Console.WriteLine($"  {llave1}- {llave2}");
        
    }
    
    
}
