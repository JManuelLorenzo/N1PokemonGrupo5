using Library.Interface;

namespace Library;

public class Player
{
    private string nombre { get; set; }
    private Dictionary <int,IPokemon> pokemons { get; set; }
    
    private IPokemon selectedPokemon { get; set; }
    

    public void cambiarNombre(string valor)
    {
        this.nombre = valor;
    }

    public void cambiarEquipo(Dictionary <int,IPokemon> equipo)
    {
        this.pokemons = equipo;
    }
    

}