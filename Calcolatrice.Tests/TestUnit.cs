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
            double result = Core.Operazioni.Somma(a, b);

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
            double result = Core.Operazioni.Sottrazione(a, b);

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
            double result = Core.Operazioni.Moltiplicazione(a, b);

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
            double result = Core.Operazioni.Divisione(a, b);

            //Asert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Operazioni_Divisione_ReturnsInfinity()
        {
            double result = Core.Operazioni.Divisione(10, 0);
            Assert.IsTrue(double.IsInfinity(result));
        }

        [TestMethod]
        public void Operazioni_Potenza_ReturnsDouble()
        {
            //Arrenge

            double a = 2;
            double b = 3;

            //Act
            double result = Core.Operazioni.Potenza(a, b);

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
            double result = Core.Operazioni.Modulo(a, b);

            //Asert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Operazioni_Radice_ReturnsDouble()
        {
            //Arrenge
            
            double a = 4;
            

            //Act
            double result = Core.Operazioni.Radice(a);

            //Asert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Operazioni_Seno_ReturnsDouble()
        {
            //Arrenge
            
            double a = 0;


            //Act
            Int32 result = (int)Core.Operazioni.Seno(a);

            //Asert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Operazioni_Coseno_ReturnsDouble()
        {
            //Arrenge
            
            double a = 0;


            //Act
            Int32 result = (int)Core.Operazioni.Coseno(a);

            //Asert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Operazioni_Tangente_ReturnsDouble()
        {
            //Arrenge
            
            double a = 0;
            

            //Act
            Int32 result = (int)Core.Operazioni.Tangente(a);

            //Asert
            Assert.AreEqual(0, result);
        }
    }
}
