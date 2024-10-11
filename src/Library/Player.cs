using Library.Interface;

namespace Library;

public class Player
{
    private string nombre { get; set; }
    private List <IPokemon> Equipo { get; set; }
    private Pokemon PokemonActivo { get; set; }

    public Player(List<Pokemon> equipo)
    {
        Equipo = equipo;
        PokemonActivo = equipo[0];
    }
    
    public void cambiarNombre(string valor)
    {
        this.nombre = valor;
    }
    public bool CambiarPokemon(int indice)
    {
        if (Equipo[indice] == PokemonActivo)
        {
            Console.WriteLine($"{Equipo[indice].Nombre} ya está en combate.");
            return false;
        }

        if (indice >= 0 && indice < Equipo.Count && Equipo[indice].EstaVivo())
        {
            PokemonActivo = Equipo[indice];
            Console.WriteLine($"{PokemonActivo.Nombre} ha sido enviado al campo.");
            return true;
        }
        else if (!Equipo[indice].EstaVivo())
        {
            Console.WriteLine("¡Ese Pokémon está debilitado y no puede pelear!");
            return false;
        }
        else
        {
            Console.WriteLine("¡Ese Pokémon no puede pelear!");
            return false;
        }
    }

    public bool QuedanPokemonVivos()
    {
        foreach (var pokemon in Equipo)
        {
            if (pokemon.EstaVivo()) return true;
        }
        return false;
    }

    public void ForzarCambioPokemon()
    {
        Console.WriteLine("Debes cambiar de Pokémon. Selecciona uno:");
        bool cambioExitoso = false;
        while (!cambioExitoso)
        {
            for (int i = 0; i < Equipo.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Equipo[i].Nombre} (HP: {Equipo[i].Health})");
            }

            int indiceCambio;
            if (int.TryParse(Console.ReadLine(), out indiceCambio))
            {
                cambioExitoso = CambiarPokemon(indiceCambio - 1);
            }
            else
            {
                Console.WriteLine("Opción inválida. Intenta nuevamente.");
            }
        }
    }
}