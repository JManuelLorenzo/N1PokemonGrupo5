using System;

namespace Program;

internal class Program
{
    static void Main(string[] args)
    {
        Facade fachada_principal = new Facade();

        Console.Clear();
        fachada_principal.startProgram();

    }
}