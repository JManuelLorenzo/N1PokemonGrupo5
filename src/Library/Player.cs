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
    public string getNombre()
    {
        return nombre;
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
        DevuelveEquipo(); // Suponiendo que esto muestra el equipo de Pokémon

        int entrada;
        while (true) // Bucle para obtener una entrada válida
        {
            try
            {
                Console.WriteLine($"Elige qué Pokémon va al campo de batalla {nombre}. Ingresa el número del Pokémon:");
                entrada = Convert.ToInt32(Console.ReadLine());

                // Intentar acceder al Pokémon seleccionado
                selectedPokemon = pokemons[entrada];
                break; // Salir del bucle si todo es correcto
            }
            catch (FormatException)
            {
                Console.WriteLine("Eso no era un número, intente de nuevo.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Eso estaba fuera de rango, intente de nuevo.");
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Eso estaba fuera de rango, intente de nuevo.");
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

    
}