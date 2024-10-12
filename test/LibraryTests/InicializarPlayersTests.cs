using NUnit.Framework;
using Library; // Ajusta según tu espacio de nombres real
using Library.Interface;

namespace LibraryTests;

[TestFixture]
public class PokemonsYHabilidadesTests
{
    private PokemonsYHablidades pokemonsYHabilidades;

    [SetUp]
    public void Setup()
    {
        pokemonsYHabilidades = new PokemonsYHablidades();
        pokemonsYHabilidades.CrearPokemons(); // Inicializa los Pokémon al crear la instancia
    }

    [Test]
    public void CrearPokemons_CreaCorrectamentePokemonsFuego()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        Assert.IsTrue(pokemons.ContainsKey(1), "El Pokémon Charizard no fue creado correctamente.");
        Assert.That(pokemons[1].GetName(), Is.EqualTo("Charizard"), "El nombre del Pokémon Charizard es incorrecto.");
    }

    [Test]
    public void CrearPokemons_CreaCorrectamentePokemonsAgua()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        Assert.IsTrue(pokemons.ContainsKey(2), "El Pokémon Gyarados no fue creado correctamente.");
        Assert.That(pokemons[2].GetName(), Is.EqualTo("Gyarados"), "El nombre del Pokémon Gyarados es incorrecto.");
    }

    [Test]
    public void CrearPokemons_CreaCorrectamentePokemonsTierra()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        Assert.IsTrue(pokemons.ContainsKey(3), "El Pokémon Golem no fue creado correctamente.");
        Assert.That(pokemons[3].GetName(), Is.EqualTo("Golem"), "El nombre del Pokémon Golem es incorrecto.");
    }

    [Test]
    public void CrearPokemons_CreaCorrectamentePokemonsPlanta()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        Assert.IsTrue(pokemons.ContainsKey(4), "El Pokémon Venusaur no fue creado correctamente.");
        Assert.That(pokemons[4].GetName(), Is.EqualTo("Venusaur"), "El nombre del Pokémon Venusaur es incorrecto.");
    }

    [Test]
    public void CrearPokemons_ContieneElNumeroCorrectoDePokemons()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        Assert.That(pokemons.Count, Is.EqualTo(7), "El número de Pokémon creados no es el correcto.");
    }

    [Test]
    public void CrearPokemons_CreaCorrectamentePokemonsAdicionales()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        Assert.IsTrue(pokemons.ContainsKey(5), "El Pokémon Blastoise no fue creado correctamente.");
        Assert.IsTrue(pokemons.ContainsKey(6), "El Pokémon Arcanine no fue creado correctamente.");
        Assert.IsTrue(pokemons.ContainsKey(7), "El Pokémon Torterra no fue creado correctamente.");
    }

    [Test]
    public void CrearPokemons_VerificaAtaquesDeCharizard()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        var charizard = pokemons[1]; // Obtener Charizard
        var ataques = charizard.GetAbilities();
        Assert.IsNotEmpty(ataques, "Charizard no tiene ataques inicializados.");
    }

    [Test]
    public void CrearPokemons_VerificaAtaquesDeGyarados()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        var gyarados = pokemons[2]; // Obtener Gyarados
        var ataques = gyarados.GetAbilities();
        Assert.IsNotEmpty(ataques, "Gyarados no tiene ataques inicializados.");
    }

    [Test]
    public void CrearPokemons_VerificaVidaDeCadaPokemon()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        Assert.That(pokemons[1].GetHealth(), Is.EqualTo(100), "Charizard no tiene la vida inicial correcta.");
        Assert.That(pokemons[2].GetHealth(), Is.EqualTo(90), "Gyarados no tiene la vida inicial correcta.");
        Assert.That(pokemons[3].GetHealth(), Is.EqualTo(85), "Golem no tiene la vida inicial correcta.");
        Assert.That(pokemons[4].GetHealth(), Is.EqualTo(60), "Venusaur no tiene la vida inicial correcta.");
        Assert.That(pokemons[5].GetHealth(), Is.EqualTo(70), "Blastoise no tiene la vida inicial correcta.");
        Assert.That(pokemons[6].GetHealth(), Is.EqualTo(60), "Arcanine no tiene la vida inicial correcta.");
        Assert.That(pokemons[7].GetHealth(), Is.EqualTo(60), "Torterra no tiene la vida inicial correcta.");
    }
}