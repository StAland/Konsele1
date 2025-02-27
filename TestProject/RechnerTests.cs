using ClassLibrary1;
using Moq;

namespace TestProject
{
    public class RechnerTests
    {
        [Fact]
        public void Addieren_RichtigeBerechnung()
        {
            var rechner = new Rechner();

            int ergebnis = rechner.Addieren(7, 4);

            Assert.Equal(11, ergebnis);
        }

        [Theory]
        [InlineData(3, 5, 8)]
        [InlineData(3, -5, -2)]
        [InlineData(3, 67, 70)]
        [InlineData(-3, 5, 2)]
        [InlineData(-3, -5, -8)]
        public void Addieren_RichtigeBerechnung_Mehrere(int a, int b, int erwartet)
        {
            var rechner = new Rechner();

            int ergebnis = rechner.Addieren(a, b);

            Assert.Equal(erwartet, ergebnis);
        }

        [Fact]
        public void Dividieren_0wirftFehler()
        {
            var rechner = new Rechner();
            Assert.Throws<DivideByZeroException>(() => rechner.Dividieren(3,0));
        }

        [Fact]
        public void Subtrahieren_RichtigeBerechnung()
        {
            var mockService = new Mock<ISubtrahierenService>();
            mockService.Setup(s => s.Subtrahieren(4, 3)).Returns(1);
            var rechner = new Rechner(mockService.Object);

            int ergebnis = rechner.Subtrahieren(4, 3);

            Assert.Equal(1, ergebnis);
            mockService.Verify(s => s.Subtrahieren(4,3), Times.Once());
        }
    }
}