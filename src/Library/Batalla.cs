using Library.Interface;

namespace Library;

public class Batalla
{   List<IAtaque> ListaAtaque1  = new List<IAtaque>();
    List<IAtaque> ListaAtaque2 = new List<IAtaque>();
    List<IAtaque> ListaAtaque3 = new List<IAtaque>();
    
    Dictionary<int, IPokemon> pokemons1; // Quizas va en el constructor, hay que probarlo.
    Dictionary<int, IPokemon> pokemons2;
    Batalla() // no se si deberia ser un metodo constructor o no
    {
        
    }

    public void CrearAtaques()
    {
        // Crear instancias de Ataque
        Ataque Rayo = new Ataque(50, true, "Rayo");
        Ataque LanzaFuego = new Ataque(70, true, "Lanza Fuego");
        Ataque Hidrobomba = new Ataque(90, false, "Hidrobomba");
        Ataque PuñoFuego = new Ataque(50, false, "Puño Fuego");
        Ataque Trueno = new Ataque(60, true, "Trueno");
        Ataque VientoCorte = new Ataque(40, false, "Viento Corte");

    // Agregar instancias a la lista
        ListaAtaque1.Add(Rayo);
        ListaAtaque1.Add(LanzaFuego);
        ListaAtaque1.Add(Hidrobomba);
        ListaAtaque1.Add(PuñoFuego);
        
        
        ListaAtaque2.Add(Trueno);
        ListaAtaque2.Add(VientoCorte);
        ListaAtaque2.Add(PuñoFuego);
        ListaAtaque2.Add(LanzaFuego);
        
        ListaAtaque3.Add(Trueno);
        ListaAtaque3.Add(PuñoFuego);
        ListaAtaque3.Add(Hidrobomba);
        ListaAtaque3.Add(Rayo);
        Jugador
    }

    public void CrearPokemons()
    {
        
    }
}