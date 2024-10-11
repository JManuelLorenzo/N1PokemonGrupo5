using System;
using Library;
using Library.Interface;

namespace Library;

public class Print
{
    public Print()
    {
    }

    public void printStart()
    {
        Console.Clear();
        Console.WriteLine("╔═════════════════════╗");
        Console.WriteLine("║       POKEMON       ║");
        Console.WriteLine("╠═════════════════════╣");
        Console.WriteLine("║ 1) Iniciar          ║");
        Console.WriteLine("║ 2) Salir            ║");
        Console.WriteLine("╚═════════════════════╝");
    }

    public void pirntEnd()
    {
        Console.Clear();
        Console.WriteLine("╔══════════════════════╗");
        Console.WriteLine("║  Nos vemos pronto!   ║");
        Console.WriteLine("╚══════════════════════╝");
    }

    public void PlayerNameInsertion(int num)
    {
        Console.WriteLine("╔═════════════════════════════════════════╗");
        Console.WriteLine($"║ Ingrese el nombre del Jugador {num}:        ║");
        Console.WriteLine("╚═════════════════════════════════════════╝");
    }

    public void pokemonSelectionPrompt()
    {
        // Pokemon Selection Prompt
        Console.WriteLine("╔═════════════════════════════════════════╗");
        Console.WriteLine("║        Selecciona tus pokemons!         ║");
        Console.WriteLine("╚═════════════════════════════════════════╝");
    }

    public void pokemonSelection() 
    {
        
    }
}