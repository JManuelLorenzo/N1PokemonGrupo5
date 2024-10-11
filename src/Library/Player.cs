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
        this.nombre = valor;
    }

    public void cambiarEquipo(Dictionary<int, IPokemon> equipo)
    {
        this.pokemons = equipo;
    }

    public void DevuelveEquipo()
    {
        foreach (int valor in
                 pokemons.Keys) // No estoy seguro de que funcione por el foreach, la logica del resto es correcta.
        {
            Console.WriteLine(valor.ToString() + "-" + pokemons[valor].Name);
        }
    }

    public void cambiarPokemon()
    {

        Console.WriteLine("Elige que Pokemon va a el campo de batalla!!!// Ingresa el pokemon por el num");
        DevuelveEquipo();
        int entrada = Convert.ToInt32(Console.ReadLine());
        if (pokemons.ContainsKey(entrada))
        {
            selectedPokemon = pokemons[entrada];

        }
        else
        {
            Console.WriteLine("No existe Pokémon con ese número.");
        }
    }

    public void EliminarPokemon(IPokemon pokemon)
    {
        Console.WriteLine($"El pokemon {pokemon} R.I.P del player {nombre}");
        foreach (int pair in pokemons.Keys)
        {
            if (pokemons[pair] == pokemon)
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
        else
        {
            return true;
        }
    }
}