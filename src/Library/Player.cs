using Library.Interface;

namespace Library;

public class Player
{
    private string nombre { get; set; }
    private List <IPokemon> pokemons { get; set; }
    
    private IPokemon selectedPokemon { get; set; }
    

    public void cambiarNombre(string valor)
    {
        this.nombre = valor;
    }

    public void cambiarEquipo(List<IPokemon> equipo)
    {
        this.pokemons = equipo;
    }
}