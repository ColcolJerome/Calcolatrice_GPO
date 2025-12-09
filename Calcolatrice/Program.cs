using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] operazioni = new string[] { "+", "-", "/", "*", "%", "^", "sen", "cos", "tan",  "sqrt" };
            string[] operazioniSingolaCifra = new string[] {"sen", "cos", "tan", "sqrt" };
            Int32 primoNumero = 0;
            String operazione = "";
            Int32 secondoNumero = 0;
            do
            {
                try
                {
                    Console.WriteLine("Inserisci il primo numero");
                    primoNumero = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci l'operazione da svolgere");
                    operazione = Console.ReadLine();
                    if (!operazioni.Contains(operazione)) { throw new ArgumentException("Inserisci una operazione valida"); }
                    if (operazioniSingolaCifra.Contains(operazione))
                    {
                        Console.WriteLine("Risultato " + Operazioni.Calcola(primoNumero, operazione).ToString());
                        
                    }
                    else
                    {
                        Console.WriteLine("Inserisci il secondo numero");
                        secondoNumero = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Risultato " + Operazioni.Calcola(primoNumero, secondoNumero, operazione).ToString());
                    }
                    break;
                }
                catch (NotAnOperationExeption e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IsInfiniteExeption e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (true);

           
        }

    }
}
