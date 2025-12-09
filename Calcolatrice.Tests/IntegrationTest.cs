using Calcolatrice;
using Microsoft.VisualStudio.TestPlatform.TestHost;
namespace Calcolatrice.Tests
{
    [TestClass]
    public sealed class IntegrationTest
    {
        [TestMethod]
        public void Operazioni_Calcola_ReturnsCorrectSum()
        {
            //Arrenge

            double a = 10;
            double b = 5;
            string operazione = "+";
            //Act
            double result = Operazioni.Calcola(a, b, operazione);

            //Asert
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void Operazioni_Calcola_ReturnsCorrectDifference()
        {
            //Arrenge

            double a = 10;
            double b = 5;
            string operazione = "-";
            //Act
            double result = Operazioni.Calcola(a, b, operazione);

            //Asert
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void Operazioni_Calcola_ReturnsCorrectProduct()
        {
            //Arrenge

            double a = 10;
            double b = 5;
            string operazione = "*";
            //Act
            double result = Operazioni.Calcola(a, b, operazione);

            //Asert
            Assert.AreEqual(50, result);
        }
        [TestMethod]
        public void Operazioni_Calcola_ReturnsCorrectDivision()
        {
            //Arrenge

            double a = 10;
            double b = 5;
            string operazione = "/";
            //Act
            double result = Operazioni.Calcola(a, b, operazione);

            //Asert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Operazioni_Calcola_ThrowsIsInfiniteExeption()
        {
            // Assert
            Assert.ThrowsException<IsInfiniteExeption>(() =>
            {
                // Act
                Operazioni.Calcola(4, 0,"/");
            });
        }
        [TestMethod]
        public void Operazioni_Calcola_ThrowsNotAnOperationExeption()
        {
            // Assert
            Assert.ThrowsException<NotAnOperationExeption>(() =>
            {
                // Act
                Operazioni.Calcola(4, 2, "$");
            });
        }
    }
}
