using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice
{
    public class Operazioni
    {
        public Operazioni() { }

        /// <summary>
        /// Effettua sui due numeri assegnati l'operazione voluta
        /// <list type="bullet">
        ///     <item>
        ///         <description>+:somma</description>
        ///     </item>
        ///     <item>
        ///         <description>-:sottrazione</description>
        ///     </item>
        ///     <item>
        ///         <description>x:moltiplicazione</description>
        ///     </item>
        ///     <item>
        ///         <description>/:divisione</description>
        ///     </item>
        ///     <item>
        ///         <description>%:modulo</description>
        ///     </item>
        ///     <item>
        ///         <description>^:potenza</description>
        ///     </item>
        /// </list>
        /// </summary>
        /// <param name="primoNumero"></param>
        /// <param name="secondoNumero"></param>
        /// <param name="operazione"></param>
        /// <exception cref = "NotAnOperationExeption" >
        /// Lanciato quando viene inserito una operazione non valida
        /// </exception>
        /// /// <exception cref = "IsInfiniteExeption" >
        /// Lanciato quando viene effettutata una divisione per 0
        /// </exception>
        public static double Calcola(double primoNumero, double secondoNumero, String operazione)
        {
            double risultato = 0;

            switch (operazione)
            {
                case "+":
                    risultato = Somma(primoNumero, secondoNumero);
                    break;
                case "-":
                    risultato = Sottrazione(primoNumero, secondoNumero);
                    break;
                case "*":
                    risultato = Moltiplicazione(primoNumero, secondoNumero);
                    break;
                case "/":
                    risultato = Divisione(primoNumero, secondoNumero);
                    if (double.IsInfinity(risultato))
                    {
                        throw new IsInfiniteExeption("Non è possibile dividere un numero per 0");
                    }
                    break;
                case "%":
                    risultato = Modulo(primoNumero, secondoNumero);
                    break;
                case "^":
                    risultato = Potenza(primoNumero, secondoNumero);
                    break;
                default:
                    throw new NotAnOperationExeption("L'operazione inserita non è valida");
            }
            return risultato;
        }
        /// <summary>
        /// Effettua sul numero assegnato l'operazione voluta
        /// <list type="bullet">
        ///     <item>
        ///         <description>sen:seno</description>
        ///     </item>
        ///     <item>
        ///         <description>cos:coseno</description>
        ///     </item>
        ///     <item>
        ///         <description>tan:tangente</description>
        ///     </item>
        ///     <item>
        ///         <description>sqrt:radice quadrata</description>
        ///     </item>
        /// </list>
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="operazione"></param>
        /// <returns></returns>
        /// <exception cref="NotAnOperationExeption"></exception>
        public static double Calcola(double numero, String operazione)
        {
            double risultato = 0;

            switch (operazione)
            {
                case "sqrt":
                    risultato = Radice(numero);
                    break;
                case "sen":
                    risultato = Seno(numero);
                    break;
                case "cos":
                    risultato = Coseno(numero);
                    break;
                case "tan":
                    risultato = Tangente(numero);
                    break;
                default:
                    throw new NotAnOperationExeption("L'operazione inserita non è valida");
            }
            return risultato;
        }
        /// <summary>
        /// Calcola la somma di due numeri dati
        /// </summary>
        /// <param name="primoNumero"></param>
        /// <param name="secondoNumero"></param>
        /// <returns>Ritorna il risultato della somma</returns>
        public static double Somma(double primoNumero, double secondoNumero) => primoNumero + secondoNumero;

        /// <summary>
        /// Calcola la sottrazione di due numeri dati
        /// </summary>
        /// <param name="primoNumero"></param>
        /// <param name="secondoNumero"></param>
        /// <returns>Ritorna il risultato della sottrazione</returns>
        public static double Sottrazione(double primoNumero, double secondoNumero) => primoNumero - secondoNumero;

        /// <summary>
        /// Calcola il prodotto di due numeri dati
        /// </summary>
        /// <param name="primoFattore"></param>
        /// <param name="secondoFattore"></param>
        /// <returns>Ritorna il risultato della moltiplicazione</returns>
        public static double Moltiplicazione(double primoFattore, double secondoFattore) => primoFattore * secondoFattore;

        /// <summary>
        /// Calcola il rapporto di due numeri dati
        /// </summary>
        /// <param name="dividendo"></param>
        /// <param name="divisore"></param>
        /// <returns>Ritorna il risultato della moltiplicazione</returns>
        /// <exception cref="System.DivideByZeroException">Lanciato se si effettua una divisione per 0</exception>
        public static double Divisione(double dividendo, double divisore)
        {
            return dividendo / divisore;
        }

        //--Nuove operazioni--
        //--Operazioni a due variabili--
        /// <summary>
        /// Calcola la potenza di due numeri dati 
        /// </summary>
        /// <param name="basePotenza"></param>
        /// <param name="esponentePotenza"></param>
        /// <returns>Ritorna il risultato della potenza</returns>
        public static double Potenza(double basePotenza, double esponentePotenza)
        {
            return Math.Pow(basePotenza, esponentePotenza);
        }
        /// <summary>
        /// Calcola il modulo di due numeri dati 
        /// </summary>
        /// <param name="dividendo"></param>
        /// <param name="divisore"></param>
        /// <returns>Ritorna il risultato del modulo</returns>
        public static double Modulo(double dividendo, double divisore) => dividendo % divisore;

        //--Operazioni a una variabile--
        /// <summary>
        /// Calcola la radice del numero dato
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Ritorna il risultato della radice</returns>
        public static double Radice(double numero) => Math.Sqrt(numero);
        /// <summary>
        /// Calcola il seno del numero dato
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Ritorna il risultato del seno</returns>
        public static double Seno(double numero) => Math.Sin(numero);
        /// <summary>
        /// Calcola il coseno del numero dato
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Ritorna il risultato del coseno</returns>
        public static double Coseno(double numero) => Math.Cos(numero);
        /// <summary>
        /// Calcola la tangente del numero dato
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Ritorna il risultato della tangente</returns>
        public static double Tangente(double numero) => Math.Tan(numero);


    }
    public class NotAnOperationExeption : Exception
    {
        public NotAnOperationExeption() { }

        public NotAnOperationExeption(string message):base(message) { }
    }
    public class IsInfiniteExeption : Exception
    {
        public IsInfiniteExeption() { }

        public IsInfiniteExeption(string message) : base(message) { }
    }
}
