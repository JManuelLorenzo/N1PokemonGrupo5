using System;
using Library.Interface;

namespace Library
{
    public class Facade
    {
       

        public Facade() { }

        public void Start()
        {
            Player player1 = new Player(); 
            Player rival = new Player();
            Batalla batalla = new Batalla();
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1) Iniciar\n2) Salir");
                
                string inicialInput = Console.ReadLine();
                int inicial = int.Parse(inicialInput);
                
                    if (inicial == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Nos vemos pronto!");
                        break;
                    }

                    if (inicial == 1)
                    {
                        Console.WriteLine("Ingrese el nombre del Jugador 1: ");
                        string nombre1 = Console.ReadLine();
                        player1.cambiarNombre(nombre1);
                        Console.WriteLine("Ingrese el nombre del Jugador 2: ");
                        string nombre2 = Console.ReadLine();
                        rival.cambiarNombre(nombre2);
                        
                        Console.WriteLine("Selecciona tus  pokemons!");
                        foreach (int valor in  batalla.DevolverDicP1().Keys) // No estoy seguro de que funcione por el foreach, la logica del resto es correcta.
                        {
                            Console.WriteLine(valor.ToString() + "-" + batalla.DevolverDicP1()[valor].Name);
                        }

                        List<IPokemon> equipoPorAsignar = new List<IPokemon>();
                        int contador = 0;
                        while (contador < 3) // 3 puede ser cualquier valor.
                        {  Console.Write("Introduce un número: ");
                            string entrada = Console.ReadLine();

                            if (int.TryParse(entrada, out int eleccion))
                            {
                                Console.WriteLine($"Has elegido: {eleccion}");
                                equipoPorAsignar.Add(batalla.DevolverDicP1()[eleccion]);
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida. Por favor, introduce un número entero.");
                            }
                            
                        }
                        player1.cambiarEquipo(equipoPorAsignar);
                    } 
                
                else
                {
                    Console.WriteLine("Por favor, introduce un número válido (1 o 2).");
                    Console.ReadLine(); 
                }
            }
        }
    }
}