using Library.Interface;
using System;
namespace Library;

public class Batalla
{  
    List<IAtaque> ListaAtaque  = new List<IAtaque>();
    List<IAtaque> ListaDeAtaqueFuego = new List<IAtaque>();
    Dictionary<string, IPokemon> pokemons1; // Quizas va en el constructor, hay que probarlo.
    Dictionary<string, IPokemon> pokemons2;
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
        ListaDeAtaqueFuego.Add(Rayo);
        ListaDeAtaqueFuego.Add(LanzaFuego);
        ListaDeAtaqueFuego.Add(Hidrobomba);
        ListaDeAtaqueFuego.Add(PuñoFuego);
        
        
        ListaAtaque.Add(Trueno);
        ListaAtaque.Add(VientoCorte);
        ListaAtaque.Add(PuñoFuego);
        ListaAtaque.Add(LanzaFuego);
        
        ListaAtaque.Add(Trueno);
        ListaAtaque.Add(PuñoFuego);
        ListaAtaque.Add(Hidrobomba);
        ListaAtaque.Add(Rayo);
    }

    public void CrearPokemons()
    {
        pokemons1.Add("Pidgot", new Pokemon(5, 10 , 8, ListaDeAtaqueFuego));
    }
}