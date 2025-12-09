using Calcolatrice;
using Microsoft.VisualStudio.TestPlatform.TestHost;
namespace Calcolatrice.Tests
{
    [TestClass]
    public sealed class TestUnit
    {
        [TestMethod]
        public void Operazioni_Somma_ReturnsDouble()
        {
            //Arrenge
            
            double a = 10;
            double b = 5;

            //Act
            double result = Operazioni.Somma(a, b);

            //Asert
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void Operazioni_Sottrazione_ReturnsDouble()
        {
            //Arrenge

            double a = 10;
            double b = 5;

            //Act
            double result = Operazioni.Sottrazione(a, b);

            //Asert
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void Operazioni_Moltiplicazione_ReturnsDouble()
        {
            //Arrenge

            double a = 10;
            double b = 5;

            //Act
            double result = Operazioni.Moltiplicazione(a, b);

            //Asert
            Assert.AreEqual(50, result);
        }
        [TestMethod]
        public void Operazioni_Divisione_ReturnsDouble()
        {
            //Arrenge

            double a = 10;
            double b = 5;

            //Act
            double result = Operazioni.Divisione(a, b);

            //Asert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Operazioni_Divisione_ReturnsInfinity()
        {
            double result = Operazioni.Divisione(10, 0);
            Assert.IsTrue(double.IsInfinity(result));
        }

        [TestMethod]
        public void Operazioni_Potenza_ReturnsDouble()
        {
            //Arrenge

            double a = 2;
            double b = 3;

            //Act
            double result = Operazioni.Potenza(a, b);

            //Asert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Operazioni_Modulo_ReturnsDouble()
        {
            //Arrenge
            
            double a = 10;
            double b = 5;

            //Act
            double result = Operazioni.Modulo(a, b);

            //Asert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Operazioni_Radice_ReturnsDouble()
        {
            //Arrenge
            
            double a = 10;
            

            //Act
            double result = Operazioni.Radice(a);

            //Asert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Operazioni_Seno_ReturnsDouble()
        {
            //Arrenge
            
            double a = 10;
            

            //Act
            double result = Operazioni.Seno(a);

            //Asert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Operazioni_Coseno_ReturnsDouble()
        {
            //Arrenge
            
            double a = 10;
            

            //Act
            double result = Operazioni.Coseno(a);

            //Asert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Operazioni_Tangente_ReturnsDouble()
        {
            //Arrenge
            
            double a = 10;
            

            //Act
            double result = Operazioni.Tangente(a);

            //Asert
            Assert.AreEqual(0, result);
        }
    }
}
