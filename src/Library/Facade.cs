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
            PokemonsYHablidades pokemonsYHablidades = new PokemonsYHablidades();
            pokemonsYHablidades.CrearPokemons();

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
                        foreach (int valor in  pokemonsYHablidades.DevolverDicP1().Keys) // No estoy seguro de que funcione por el foreach, la logica del resto es correcta.
                        {
                            Console.WriteLine(valor.ToString() + "-" + pokemonsYHablidades.DevolverDicP1()[valor].Name);
                        }

                        Dictionary<int,IPokemon> equipoPorAsignar = new Dictionary<int,IPokemon>(); // Lista temporal de Pokemons
                        int contador = 0; // Empieza en 0 para hacer que los pokemons en el nuevo dic comiencen desde 1.
                        while (contador < 3) // 3 puede ser cualquier valor.
                        {  Console.Write("Introduce un número: ");
                            string entrada = Console.ReadLine();
                                int procesado  = Convert.ToInt32(entrada);
                            if (int.TryParse(entrada, out int eleccion))
                            {
                                contador++;
                                Console.WriteLine($"Has elegido: {procesado}");
                                equipoPorAsignar.Add(contador,pokemonsYHablidades.DevolverDicP1()[procesado]); // Se van agregando los pokemons a una lista temporal
                                
                            }  
                            else
                            {
                                Console.WriteLine("Entrada no válida. Por favor, introduce un número entero.");
                            }
                            
                        }
                        
                        player1.cambiarEquipo(equipoPorAsignar); // Se Cambian los pokemons por el  principal
                        Console.WriteLine($"Genial el Equipo de tu rival se decidira de manera aleatoria.");
                        
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