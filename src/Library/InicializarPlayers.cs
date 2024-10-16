using Library.Interface;

namespace Library;

public class InicializarPlayers
{
    Player player1 = new Player();
    Player rival = new Player();
    Print impresiones = new Print();


    public Player Jugador()
    {
        return player1;
    }

    public Player Rival()
    {
        return rival;
    }

    public void NombresPlayers()
    {
        impresiones.playerName(1);
        string nombre1 = Console.ReadLine();
        player1.cambiarNombre(nombre1);
        impresiones.playerName(2);
        string nombre2 = Console.ReadLine();
        rival.cambiarNombre(nombre2);
    }

    public void EquipoPlayers()
    {
        PokemonsYHablidades pokemonsYHablidades = new PokemonsYHablidades();
        pokemonsYHablidades.CrearPokemons();

        AsignarCadaPokemon(pokemonsYHablidades, 1,player1);

        AsignarCadaPokemon(pokemonsYHablidades,2,rival);
        
        void AsignarCadaPokemon(PokemonsYHablidades ClaseCreadora, int opcion, Player player)
        {
            Dictionary<int, IPokemon> Dic = new Dictionary<int, IPokemon>();
            
            if (opcion == 1)
            {
                Dic = ClaseCreadora.DevolverDicP1();
            }
            else
            {
                Dic = ClaseCreadora.DevolverDicP2();
            }

            impresiones.selectSign();
            foreach (int valor in Dic.Keys) 
            {
                Console.WriteLine("╔═════════════════════════════════════════╗");
                Console.WriteLine("  "+(valor + "-" + Dic[valor].GetName()));
                Console.WriteLine("╚═════════════════════════════════════════╝");
            }

            Dictionary<int, IPokemon> P1equipoPorAsignar = new Dictionary<int, IPokemon>(); // Lista temporal de Pokemons
            int contador = 0; // Empieza en 0 para hacer que los pokemons en el nuevo dic comiencen desde 1.

            while (contador < 3) // 3 puede ser cualquier valor.
            {
                Console.Write("Introduce un número: ");
                string entrada = Console.ReadLine();

                try
                {
                    int procesado = Convert.ToInt32(entrada);
        
                    // Verifica que el número esté en el rango válido
                    if (procesado > 0 && procesado <= Dic.Count)
                    {
                        if (P1equipoPorAsignar.ContainsKey(procesado))
                        {
                            Console.WriteLine("Elige un pokemon diferente al que ya tienes.");
                        }
                        else
                        {
                            contador++;
                            Console.WriteLine($"Has elegido: {procesado}");
                            P1equipoPorAsignar.Add(contador,
                                Dic[procesado]); // Se van agregando los pokemons a una lista temporal    
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Por favor, introduce un número entero entre 1 y " + Dic.Count + ".");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada no válida. Por favor, introduce un número entero.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("El número es demasiado grande. Por favor, introduce un número válido.");
                }
            }


            player.cambiarEquipo(P1equipoPorAsignar); // Se Cambian los pokemons por el  principal
            impresiones.tuEquipoSign();
            foreach (var item in P1equipoPorAsignar)
            {
                string llave = item.Key.ToString();
                string llave2 = item.Value.Name;
                impresiones.printMyTeam(llave, llave2);
                
            }
            impresiones.parteDeAbajo();
        }
    }

    public void PokemonInicial()
        {
            player1.cambiarPokemon();

            rival.cambiarPokemon();
        }

}

