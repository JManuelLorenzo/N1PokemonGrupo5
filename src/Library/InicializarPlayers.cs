using Library.Interface;

namespace Library;
using static IPokemon;
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

    public void EquipoPlayers()  {
        PokemonsYHablidades pokemonsYHablidades = new PokemonsYHablidades();
        pokemonsYHablidades.CrearPokemons();
        
        impresiones.mostrarListaPokemons();

        foreach (int valor in
                 pokemonsYHablidades.DevolverDicP1()
                     .Keys) // No estoy seguro de que funcione por el foreach, la logica del resto es correcta.
                {
                    Console.WriteLine(valor.ToString() + "-" + pokemonsYHablidades.DevolverDicP1()[valor].Name);
                }

                Dictionary<int, IPokemon>
                    P1equipoPorAsignar = new Dictionary<int, IPokemon>(); // Lista temporal de Pokemons
                int contador = 0; // Empieza en 0 para hacer que los pokemons en el nuevo dic comiencen desde 1.
                while (contador < 3) // 3 puede ser cualquier valor.
                {
                    Console.Write("Introduce un número: ");
                    string entrada = Console.ReadLine();
                    int procesado = Convert.ToInt32(entrada);
                    if (int.TryParse(entrada, out int eleccion))
                    {
                        contador++;
                        Console.WriteLine($"Has elegido: {procesado}");
                        P1equipoPorAsignar.Add(contador,
                            pokemonsYHablidades.DevolverDicP1()[procesado]); // Se van agregando los pokemons a una lista temporal

                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Por favor, introduce un número entero.");
                    }

                }

                player1.cambiarEquipo(P1equipoPorAsignar); // Se Cambian los pokemons por el  principal
                foreach (var item in P1equipoPorAsignar)
                {
                    Console.WriteLine($"Clave: {item.Key}, Valor: {item.Value.Name}");
                }

                Console.WriteLine($"Elige los pokemons del rival");

                Dictionary<int, IPokemon> P2equipoPorAsignar = new Dictionary<int, IPokemon>();

                Console.WriteLine("Selecciona los pokemons de tu rival!");
                foreach (int valor in
                         pokemonsYHablidades.DevolverDicP2()
                             .Keys) // No estoy seguro de que funcione por el foreach, la logica del resto es correcta.
                {
                    Console.WriteLine(valor.ToString() + "-" + pokemonsYHablidades.DevolverDicP2()[valor].Name);
                }

                contador = 0; // Empieza en 0 para hacer que los pokemons en el nuevo dic comiencen desde 1.

                while (contador < 3) // 3 puede ser cualquier valor.
                {
                    Console.Write("Introduce un número: ");
                    string entrada = Console.ReadLine();
                    int procesado = Convert.ToInt32(entrada);
                    if (int.TryParse(entrada, out int eleccion))
                    {
                        contador++;
                        Console.WriteLine($"Has elegido: {procesado}");
                        P2equipoPorAsignar.Add(contador, pokemonsYHablidades.DevolverDicP2()[procesado]); // Se van agregando los pokemons a una lista temporal

                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Por favor, introduce un número entero.");
                    }

                }
                rival.cambiarEquipo(P2equipoPorAsignar);
                foreach (var item in P2equipoPorAsignar)
                {
                    Console.WriteLine($"Clave: {item.Key}, Valor: {item.Value.Name}");
                }
                
    }

    public void PokemonInicial()
    {
        player1.cambiarPokemon();
        
        rival.cambiarPokemon();
    }
    
}
    
