using NUnit.Framework;
using Library;
using Library.Interface;

namespace LibraryTests;

[TestFixture]
public class PlayerTests
{
    private Player player;
    private IPokemon mockPokemon;

    [SetUp]
    public void Setup()
    {
        player = new Player();
        mockPokemon = new Pokemon("Pikachu", 10, 100, 5, new List<IAtaque>()); // Pokémon de prueba
    }

    [Test]
    public void CambiarNombre_ActualizaNombreCorrectamente()
    {
        player.cambiarNombre("Ash");
        Assert.That(player.getNombre(), Is.EqualTo("Ash"), "El nombre del jugador no se actualizó correctamente.");
    }

    [Test]
    public void CambiarEquipo_ActualizaEquipoCorrectamente()
    {
        var equipo = new Dictionary<int, IPokemon>
        {
            { 1, mockPokemon }
        };

        player.cambiarEquipo(equipo);
        Assert.IsTrue(player.QuedanPokemons(), "El jugador debería tener Pokémon en el equipo.");
    }

    [Test]
    public void DevuelveEquipo_MuestraElEquipoCorrectamente()
    {
        var equipo = new Dictionary<int, IPokemon>
        {
            { 1, mockPokemon }
        };

        player.cambiarEquipo(equipo);
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            player.DevuelveEquipo();
            var result = sw.ToString().Trim();

            Assert.IsTrue(result.Contains("1-Pikachu"), "El equipo no se muestra correctamente.");
        }
    }

    [Test]
    public void CambiarPokemon_SeleccionaPokemonCorrectamente()
    {
        var equipo = new Dictionary<int, IPokemon>
        {
            { 1, mockPokemon }
        };

        player.cambiarEquipo(equipo);
        player.cambiarPokemon();

        Assert.That(player.getSelectedPokemon(), Is.EqualTo(mockPokemon), "El Pokémon seleccionado no es el correcto.");
    }

    [Test]
    public void EliminarPokemon_RemuevePokemonCorrectamente()
    {
        var equipo = new Dictionary<int, IPokemon>
        {
            { 1, mockPokemon }
        };

        player.cambiarEquipo(equipo);
        mockPokemon.RecibirDaño(100); // Eliminar el Pokémon
        player.EliminarPokemon(mockPokemon);

        Assert.IsFalse(player.QuedanPokemons(), "El jugador debería haber quedado sin Pokémon.");
    }
}