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
        /// </list>
        /// </summary>
        /// <param name="primoNumero">Primo numero dell'operazione</param>
        /// <param name="secondoNumero">Secondo numero dell'operazione</param>
        /// <param name="operazione">Operazione da calcolare</param>
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
        /// <param name="primoNumero"></param>
        /// <param name="secondoNumero"></param>
        /// <returns>Ritorna il risultato della moltiplicazione</returns>
        public static double Moltiplicazione(double primoNumero, double secondoNumero) => primoNumero * secondoNumero;

        /// <summary>
        /// Calcola il rapporto di due numeri dati
        /// </summary>
        /// <param name="primoNumero"></param>
        /// <param name="secondoNumero"></param>
        /// <returns>Ritorna il risultato della moltiplicazione</returns>
        /// <exception cref="System.DivideByZeroException">Lanciato se si effettua una divisione per 0</exception>
        public static double Divisione(double primoNumero, double secondoNumero)
        {
                return primoNumero / secondoNumero;
        }
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
