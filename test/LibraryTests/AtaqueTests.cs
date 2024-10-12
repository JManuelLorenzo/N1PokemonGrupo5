using NUnit.Framework;
using Library; // Adjust based on your actual namespace

namespace LibraryTests
{
    [TestFixture]
    public class AtaqueTests
    {
        private Ataque ataque;

        [SetUp]
        public void Setup()
        {
            // Inicializa el ataque con valores de prueba
            ataque = new Ataque(50, true, "Fuego Sagrado");
        }

        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            Assert.That(ataque.Poder, Is.EqualTo(50), "El poder del ataque no se inicializó correctamente.");
            Assert.IsTrue(ataque.Especial, "La propiedad 'Especial' no se inicializó correctamente.");
            Assert.That(ataque.Nombre, Is.EqualTo("Fuego Sagrado"), "El nombre del ataque no se inicializó correctamente.");
        }

        [Test]
        public void GetNombre_ReturnsCorrectName()
        {
            Assert.That(ataque.GetNombre(), Is.EqualTo("Fuego Sagrado"), "GetNombre() no devuelve el nombre correcto.");
        }

        [Test]
        public void GetPower_ReturnsCorrectPower()
        {
            Assert.That(ataque.GetPower(), Is.EqualTo(50), "GetPower() no devuelve el poder correcto.");
        }

        [Test]
        public void Constructor_HandlesZeroPower()
        {
            Ataque ataqueConPoderCero = new Ataque(0, false, "Ataque Débil");
            Assert.That(ataqueConPoderCero.GetPower(), Is.EqualTo(0), "El poder del ataque debe ser 0.");
            Assert.That(ataqueConPoderCero.GetNombre(), Is.EqualTo("Ataque Débil"), "El nombre del ataque no se inicializó correctamente.");
            Assert.IsFalse(ataqueConPoderCero.Especial, "La propiedad 'Especial' debe ser false.");
        }

        [Test]
        public void Constructor_HandlesSpecialAndNormalAttacks()
        {
            Ataque ataqueEspecial = new Ataque(75, true, "Bola de Fuego");
            Ataque ataqueNormal = new Ataque(30, false, "Golpe Normal");

            Assert.IsTrue(ataqueEspecial.Especial, "El ataque 'Bola de Fuego' debe ser especial.");
            Assert.IsFalse(ataqueNormal.Especial, "El ataque 'Golpe Normal' debe ser normal.");
        }
    }
}
