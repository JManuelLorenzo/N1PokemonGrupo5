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
            
        }
    }
}