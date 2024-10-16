using Library.Interface;

namespace Library;

public class Player
{

    private string nombre { get; set; }
    private Dictionary<int, IPokemon> pokemons { get; set; }

    private IPokemon selectedPokemon { get; set; }

    public Player()
    {
        pokemons = new Dictionary<int, IPokemon>(); // Inicializa el diccionario
    }


    public void cambiarNombre(string valor)
    {
        nombre = valor;
    }

    public void cambiarEquipo(Dictionary<int, IPokemon> equipo)
    {
        pokemons = equipo;
    }

    public void DevuelveEquipo()
    {
        foreach (int valor in
                 pokemons.Keys) // No estoy seguro de que funcione por el foreach, la logica del resto es correcta.
        {
            Console.WriteLine(valor + "-" + pokemons[valor].Name);
        }
    }

    public void cambiarPokemon()
    {
        DevuelveEquipo();
        {
            int entrada;
            do
            {
                try
                {
                    Console.WriteLine($"Elige que Pokemon va a el campo de batalla {getNombre()}// Ingresa el pokemon por el num");
                    entrada = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Eso no era un numero, intente de vuelta");
                }
            } while (true);
            if (pokemons.ContainsKey(entrada))
            {
                selectedPokemon = pokemons[entrada];


            }
            else
            {
                Console.WriteLine("No existe Pokémon con ese número, se te asignara uno aleatorio de tu equipo");
                Random random = new Random();
                int randomNumber = random.Next(1, pokemons.Count+1);
                selectedPokemon = pokemons[randomNumber];
            }
        }
    }

    public void EliminarPokemon(IPokemon pokemon)
    {
        Console.WriteLine($"El pokemon {getSelectedPokemon().GetName()} R.I.P del player {nombre}");
        foreach (int pair in pokemons.Keys)
        {
            if (pokemons[pair].GetHealth() == 0)
            {
                pokemons.Remove(pair);
                
            }
        }
        cambiarPokemon();
    }

    public bool QuedanPokemons()
    {
        if (pokemons.Count == 0)
        {
            return false;
        }

        return true;
    }

    public IPokemon getSelectedPokemon()
    {
        return selectedPokemon;
    }

    public string getNombre()
    {
        return nombre;
    }
}