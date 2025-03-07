using ClassLibrary1;
using Moq;

namespace RechnerTests
{
    public class RechnerTest
    {
        [Fact]
        public void Addieren_RichtigGerechnet()
        {
            var rechner = new Rechner();
            int ergebnis = rechner.Addieren(6, 13);
            Assert.Equal(19, ergebnis);
        }

        [Theory]
        [InlineData(5,3,2)]
        [InlineData(3,5,-2)]
        [InlineData(4,3,1)]
        [InlineData(7,0,7)]
        public void Subtrahieren_RichtigGerechnet(int a, int b, int erwartet)
        {
            var rechner = new Rechner();
            int ergebnis = rechner.Subtrahieren(a, b);
            Assert.Equal(erwartet, ergebnis);
        }

        [Fact]
        public void Subtrahieren_RichtigMitService()
        {
            var mockService = new Mock<ISubtrahierenService>();
            mockService.Setup(m => m.Subtrahieren(3,2)).Returns(1);
            var rechner = new Rechner(mockService.Object);

            int ergebnis = rechner.Subtrahieren(3, 2);
            Assert.Equal(1, ergebnis);
            mockService.Verify(m => m.Subtrahieren(3,2), Times.Once());
        }
    }
}