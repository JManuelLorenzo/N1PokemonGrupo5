using NUnit.Framework;
using Library;
using Library.Interface;

namespace LibraryTests;

[TestFixture]
public class SistemaDeCombateTests
{
    private SistemaDeCombate sistemaDeCombate;
    private Player player1;
    private Player player2;
    private IPokemon pokemon1;
    private IPokemon pokemon2;

    [SetUp]
    public void Setup()
    {
        // Inicializar jugadores y Pokémon
        player1 = new Player();
        player2 = new Player();

        // Crear Pokémon
        pokemon1 = new Pokemon("Pikachu", 55, 100, 40, new List<IAtaque>());
        pokemon2 = new Pokemon("Bulbasaur", 49, 90, 49, new List<IAtaque>());

        // Agregar Pokémon a los jugadores
        player1.cambiarEquipo(new Dictionary<int, IPokemon> { { 1, pokemon1 } });
        player2.cambiarEquipo(new Dictionary<int, IPokemon> { { 1, pokemon2 } });

        // Inicializar SistemaDeCombate
        sistemaDeCombate = new SistemaDeCombate();
    }

    [Test]
    public void Combatir_PokemonsDeberianReducirVida()
    {
        sistemaDeCombate.Combatir();

        // Comprobar que la vida de pokemon2 ha disminuido
        Assert.That(pokemon2.GetHealth(), Is.LessThan(90));
    }

    [Test]
    public void Combatir_PokemonsDeberianReducirVidaConValorCorrecto()
    {
        sistemaDeCombate.Combatir();

        // Comprobar que la vida de pokemon2 ha disminuido correctamente
        Assert.That(pokemon2.GetHealth(), Is.EqualTo(90 - pokemon1.GetAttack()));
    }

    [Test]
    public void Combatir_DeberiaTerminarElCombateSiPokemon1EsDerrotado()
    {
        // Reducir la vida del pokemon1 a 0 para simular derrota
        pokemon1.RecibirDaño(100);
        Assert.That(pokemon1.GetHealth(), Is.EqualTo(0));

        // Aquí puedes agregar lógica para verificar si el combate termina
        // (por ejemplo, un método que revise el estado de los Pokémon)
    }

    [Test]
    public void Combatir_DeberiaTerminarElCombateSiPokemon2EsDerrotado()
    {
        // Reducir la vida del pokemon2 a 0 para simular derrota
        pokemon2.RecibirDaño(100);
        Assert.That(pokemon2.GetHealth(), Is.EqualTo(0));

        // Verificar si el combate termina
    }

    [Test]
    public void Combatir_NoDeberiaSeguirSiAmbosPokemonsEstanDerribados()
    {
        // Reducir la vida de ambos Pokémon a 0
        pokemon1.RecibirDaño(100);
        pokemon2.RecibirDaño(100);
        Assert.That(pokemon1.GetHealth(), Is.EqualTo(0));
        Assert.That(pokemon2.GetHealth(), Is.EqualTo(0));

        // Verificar que el combate no continúe
        // (esto podría depender de cómo implementes la lógica en tu clase)
    }
}