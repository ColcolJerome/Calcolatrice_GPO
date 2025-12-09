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
            double result = Core.Operazioni.Calcola(a, b, operazione);

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
            double result = Core.Operazioni.Calcola(a, b, operazione);

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
            double result = Core.Operazioni.Calcola(a, b, operazione);

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
            double result = Core.Operazioni.Calcola(a, b, operazione);

            //Asert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Operazioni_Calcola_ReturnsCorrectPower()
        {
            //Arrenge

            double a = 10;
            double b = 2;
            string operazione = "^";
            //Act
            double result = Core.Operazioni.Calcola(a, b, operazione);

            //Asert
            Assert.AreEqual(100, result);
        }
        [TestMethod]
        public void Operazioni_Calcola_ReturnsCorrectModule()
        {
            //Arrenge

            double a = 10;
            double b = 2;
            string operazione = "%";
            //Act
            double result = Core.Operazioni.Calcola(a, b, operazione);

            //Asert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void Operazioni_Calcola_ReturnsCorrectSin()
        {
            //Arrenge

            double a = 0;
            string operazione = "sen";
            //Act
            double result = Core.Operazioni.Calcola(a, operazione);

            //Asert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void Operazioni_Calcola_ReturnsCorrectCos()
        {
            //Arrenge

            double a = 90;
            string operazione = "cos";
            //Act
            Int32 result = (int)Core.Operazioni.Calcola(a, operazione);

            //Asert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void Operazioni_Calcola_ReturnsCorrectTan()
        {
            //Arrenge

            double a = 0;
            string operazione = "tan";
            //Act
            double result = Core.Operazioni.Calcola(a, operazione);

            //Asert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void Operazioni_Calcola_ReturnsCorrectSqrt()
        {
            //Arrenge

            double a = 4;
            string operazione = "sqrt";
            //Act
            double result = Core.Operazioni.Calcola(a, operazione);

            //Asert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Operazioni_Calcola_ThrowsIsInfiniteExeption()
        {
            // Assert
            Assert.ThrowsException<Core.IsInfiniteExeption>(() =>
            {
                // Act
                    Core.Operazioni.Calcola(4, 0,"/");
            });
        }
        [TestMethod]
        public void Operazioni_Calcola_ThrowsNotAnOperationExeptionOnTwoNumber()
        {
            // Assert
            Assert.ThrowsException<Core.NotAnOperationExeption>(() =>
            {
                // Act
                Core.Operazioni.Calcola(4, 2, "$");
            });
        }
        [TestMethod]
        public void Operazioni_Calcola_ThrowsNotAnOperationExeptionOnOneNumber()
        {
            // Assert
            Assert.ThrowsException<Core.NotAnOperationExeption>(() =>
            {
                // Act
                Core.Operazioni.Calcola(4, "$");
            });
        }
    }
}
