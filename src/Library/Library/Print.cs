namespace Library;

public class Print
{
    PokemonsYHablidades pokemonsYHablidades = new PokemonsYHablidades();

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

    public void mostrarListaPokemons()
    {
        // Pokemon Selection Prompt
        Console.WriteLine("╔═════════════════════════════════════════╗");
        Console.WriteLine("║        Selecciona tus pokemons!         ║");
        Console.WriteLine("╚═════════════════════════════════════════╝");
        foreach (int valor in pokemonsYHablidades.DevolverDicP1().Keys) // No estoy seguro de que funcione por el foreach, la logica del resto es correcta.
        {
            Console.WriteLine("╔═════════════════════════════════════════╗");
            Console.WriteLine(valor + "-" + pokemonsYHablidades.DevolverDicP1()[valor].Name + " ║");
            Console.WriteLine("╚═════════════════════════════════════════╝");

        }
        
    }

    public void mostrarListaPokemonsRival()
    {
        Console.WriteLine("╔═════════════════════════════════════════╗");
        Console.WriteLine("║        Selecciona sus pokemons!         ║");
        Console.WriteLine("╚═════════════════════════════════════════╝");
    }
}
