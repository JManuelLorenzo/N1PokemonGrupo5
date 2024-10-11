using Library.Interface;

namespace Library;

public class Player
{
    private string nombre { get; set; }
    private List <IPokemon> pokemons { get; set; }

    public void cambiarNombre(string valor)
    {
        this.nombre = valor;
    }
}