using System;

namespace Library
{
    public class Facade
    {
        private int A = 0;  // Declare A as a class field

        public Facade() { }

        public void Start()
        {
            Player player1 = new Player(); 
            Player rival = new Player();
            

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
                        Console.WriteLine("Ingrese el nombre del Juador 1: ");
                        
                        
                        
                        Console.WriteLine("Seleccione los pokemons!");
                        foreach (Pokemon p in 10)
                        {
                            Console.Write(" "+ p);
                        }
                        string nombre2 = Console.ReadLine();
                    }
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