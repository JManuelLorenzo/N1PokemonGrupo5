using Library;
using NUnit.Framework;

namespace LibraryTests
{
    public class FacadeTests
    {
        private Facade facade;

        [SetUp]
        public void Setup()
        {
            facade = new Facade();
        }

        [Test]
        public void CrearJugadores_DebeInicializarJugadores()
        {
            // Assert.That(facade.Start(), "Start");   
        }
    }
}
