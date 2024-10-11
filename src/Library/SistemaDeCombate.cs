using Library.Interface;

namespace Library;

public class SistemaDeCombate
{
    public void Combatir()
    {
        InicializarPlayers ejemplo = new InicializarPlayers();
        ejemplo.NombresPlayers();
        ejemplo.EquipoPlayers();
        ejemplo.PokemonInicial();
        Player jugador1 = ejemplo.Jugador();
        Player rival = ejemplo.Rival();
        while (jugador1.QuedanPokemons() && rival.QuedanPokemons())
        {
         turno(jugador1, rival);
         turno(rival, jugador1);
        }

        Console.WriteLine("El juego ha terminado");
        Console.ReadLine();
    }

    public void Atacar(Player playerEnTurno, Player playerEnemigo)
    {
        
        IPokemon pokemonenturno = playerEnTurno.getSelectedPokemon();
        IPokemon pokemonenemigo = playerEnemigo.getSelectedPokemon();
        List<IAtaque>HablidadesActuales = pokemonenturno.GetAbilities();
        Console.WriteLine("Elige tu Ataque:");
        int contador = 0;
        foreach (var ataque in HablidadesActuales)
        {
            contador++;

        Console.WriteLine($"{contador})" + " - "+ ataque.Nombre +"\n");
        int ataqueElegido = Convert.ToInt32(Console.ReadLine());
        IAtaque HablidadElegida = HablidadesActuales[ataqueElegido];
        int Damage = procesamientoDaño(pokemonenturno, HablidadElegida);
        pokemonenemigo.RecibirDaño(Damage);

        }
    } 

    public void turno(Player playerenturno, Player playerenemigo)
    {
        IPokemon pokemonenturno = playerenturno.getSelectedPokemon();
        IPokemon pokemonenemigo = playerenemigo.getSelectedPokemon();

        int VidaPokemonEnTurno = pokemonenturno.GetHealth();
        if (VidaPokemonEnTurno == 0)
        {
            playerenturno.EliminarPokemon(pokemonenturno);
            playerenturno.cambiarPokemon();
        }
        else
        {
            Console.WriteLine("Es tu Turno, Que quieres hacer?");
            Console.WriteLine($"Tu pokemon es {pokemonenturno.GetName()} y tiene {VidaPokemonEnTurno} de vida");
            Console.WriteLine("pulsa A para atacar O B para cambiar");
            string Entrada = Console.ReadLine();
            if (Entrada == "A")
            {
                Atacar(playerenturno, playerenemigo);
            }
            else
            {
                playerenturno.cambiarPokemon();
            }
        }

        pokemonenturno.Atacar(pokemonenemigo);
    }

    public int procesamientoDaño(IPokemon pokemon, IAtaque habilidad)
    {
        
        int ValorDeDañoPokemon = pokemon.GetAttack();
        int ValorDePotenciaHablidad = habilidad.GetPower();
        int DañoTotalPokemon = ValorDeDañoPokemon * (ValorDePotenciaHablidad / 80);
        return DañoTotalPokemon;
    }
}