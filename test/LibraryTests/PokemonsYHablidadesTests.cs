using NUnit.Framework;
using Library;
using Library.Interface;

namespace LibraryTests;

[TestFixture]
public class PokemonsYHablidadesTests
{
    private PokemonsYHablidades pokemonsYHabilidades;

    [SetUp]
    public void Setup()
    {
        pokemonsYHabilidades = new PokemonsYHablidades();
        pokemonsYHabilidades.CrearPokemons(); // Inicializa los Pokémon al crear la instancia
    }

    [Test]
    public void CrearPokemons_VerificaCantidadDePokemons()
    {
        var pokemons1 = pokemonsYHabilidades.DevolverDicP1();
        var pokemons2 = pokemonsYHabilidades.DevolverDicP2();
        Assert.AreEqual(7, pokemons1.Count, "El número de Pokémon en el diccionario de jugador 1 no es correcto.");
        Assert.AreEqual(7, pokemons2.Count, "El número de Pokémon en el diccionario de jugador 2 no es correcto.");
    }

    [Test]
    public void CrearPokemons_VerificaNombreDePokemonFuego()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        Assert.IsTrue(pokemons.ContainsKey(1), "El Pokémon Charizard no fue creado correctamente.");
        Assert.AreEqual("Charizard", pokemons[1].GetName(), "El nombre del Pokémon Charizard es incorrecto.");
    }

    [Test]
    public void CrearPokemons_VerificaNombreDePokemonAgua()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        Assert.IsTrue(pokemons.ContainsKey(2), "El Pokémon Gyarados no fue creado correctamente.");
        Assert.AreEqual("Gyarados", pokemons[2].GetName(), "El nombre del Pokémon Gyarados es incorrecto.");
    }

    [Test]
    public void CrearPokemons_VerificaNombreDePokemonTierra()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        Assert.IsTrue(pokemons.ContainsKey(3), "El Pokémon Golem no fue creado correctamente.");
        Assert.AreEqual("Golem", pokemons[3].GetName(), "El nombre del Pokémon Golem es incorrecto.");
    }

    [Test]
    public void CrearPokemons_VerificaNombreDePokemonPlanta()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        Assert.IsTrue(pokemons.ContainsKey(4), "El Pokémon Venusaur no fue creado correctamente.");
        Assert.AreEqual("Venusaur", pokemons[4].GetName(), "El nombre del Pokémon Venusaur es incorrecto.");
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
        Assert.AreEqual(100, pokemons[1].GetHealth(), "Charizard no tiene la vida inicial correcta.");
        Assert.AreEqual(90, pokemons[2].GetHealth(), "Gyarados no tiene la vida inicial correcta.");
        Assert.AreEqual(85, pokemons[3].GetHealth(), "Golem no tiene la vida inicial correcta.");
        Assert.AreEqual(60, pokemons[4].GetHealth(), "Venusaur no tiene la vida inicial correcta.");
        Assert.AreEqual(70, pokemons[5].GetHealth(), "Blastoise no tiene la vida inicial correcta.");
        Assert.AreEqual(60, pokemons[6].GetHealth(), "Arcanine no tiene la vida inicial correcta.");
        Assert.AreEqual(60, pokemons[7].GetHealth(), "Torterra no tiene la vida inicial correcta.");
    }

    [Test]
    public void CrearPokemons_VerificaDefensaDeCadaPokemon()
    {
        var pokemons = pokemonsYHabilidades.DevolverDicP1();
        Assert.AreEqual(15, pokemons[1].GetDefense(), "Charizard no tiene la defensa inicial correcta.");
        Assert.AreEqual(12, pokemons[2].GetDefense(), "Gyarados no tiene la defensa inicial correcta.");
        Assert.AreEqual(22, pokemons[3].GetDefense(), "Golem no tiene la defensa inicial correcta.");
        Assert.AreEqual(18, pokemons[4].GetDefense(), "Venusaur no tiene la defensa inicial correcta.");
        Assert.AreEqual(16, pokemons[5].GetDefense(), "Blastoise no tiene la defensa inicial correcta.");
        Assert.AreEqual(13, pokemons[6].GetDefense(), "Arcanine no tiene la defensa inicial correcta.");
        Assert.AreEqual(24, pokemons[7].GetDefense(), "Torterra no tiene la defensa inicial correcta.");
    }
}