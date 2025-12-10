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

            Console.OutputEncoding = Encoding.UTF8;

            string[] operazioni = new string[] { "+", "-", "/", "*", "%", "^", "sen", "cos", "tan", "sqrt" };
            string[] operazioniSingolaCifra = new string[] { "sen", "cos", "tan", "sqrt" };
            Int32 primoNumero = 0;
            String operazione = "";
            Int32 secondoNumero = 0;

            MostraHeader();
            MostraOperazioniDisponibili();

            do
            {
                try
                {
                    MostraBoxInput("PRIMO NUMERO");
                    Console.Write("  ➤ ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    primoNumero = Int32.Parse(Console.ReadLine());
                    Console.ResetColor();

                    MostraBoxInput("OPERAZIONE");
                    Console.Write("  ➤ ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    operazione = Console.ReadLine();
                    Console.ResetColor();

                    if (!operazioni.Contains(operazione))
                    {
                        throw new Core.NotAnOperationExeption();
                    }

                    if (operazioniSingolaCifra.Contains(operazione))
                    {
                        MostraRisultato(primoNumero, operazione, 0, Core.Operazioni.Calcola(primoNumero, operazione), true);
                    }
                    else
                    {
                        MostraBoxInput("SECONDO NUMERO");
                        Console.Write("  ➤ ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        secondoNumero = Int32.Parse(Console.ReadLine());
                        Console.ResetColor();

                        MostraRisultato(primoNumero, operazione, secondoNumero, Core.Operazioni.Calcola(primoNumero, secondoNumero, operazione), false);
                    }
                    break;
                }
                catch (Core.NotAnOperationExeption e)
                {
                    MostraErrore(e.Message);
                }
                catch (Core.IsInfiniteExeption e)
                {
                    MostraErrore(e.Message);
                }

            } while (true);

            MostraArrivederci();
        }

        static void MostraHeader()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
  ╔═══════════════════════════════════════════════════════════════╗
  ║                                                               ║
  ║    ██████╗ █████╗ ██╗      ██████╗ ██████╗ ██╗      █████╗    ║
  ║   ██╔════╝██╔══██╗██║     ██╔════╝██╔═══██╗██║     ██╔══██╗   ║
  ║   ██║     ███████║██║     ██║     ██║   ██║██║     ███████║   ║
  ║   ██║     ██╔══██║██║     ██║     ██║   ██║██║     ██╔══██║   ║
  ║   ╚██████╗██║  ██║███████╗╚██████╗╚██████╔╝███████╗██║  ██║   ║
  ║    ╚═════╝╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝   ║
  ║                                                               ║
  ║              ★ CALCOLATRICE SCIENTIFICA v1.0 ★                ║
  ║                                                               ║
  ╚═══════════════════════════════════════════════════════════════╝
");
            Console.ResetColor();
        }

        static void MostraOperazioniDisponibili()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
  ┌─────────────────────────────────────────────────────────────┐
  │                   OPERAZIONI DISPONIBILI                    │
  ├─────────────────────────────────────────────────────────────┤
  │                                                             │
  │   ┌─────────────────────┐    ┌─────────────────────────┐    │
  │   │  OPERAZIONI BASE    │    │  OPERAZIONI AVANZATE    │    │
  │   ├─────────────────────┤    ├─────────────────────────┤    │
  │   │  +   Addizione      │    │  sen   Seno             │    │
  │   │  -   Sottrazione    │    │  cos   Coseno           │    │
  │   │  *   Moltiplicazione│    │  tan   Tangente         │    │
  │   │  /   Divisione      │    │  sqrt  Radice Quadrata  │    │
  │   │  %   Modulo         │    │  ^     Potenza          │    │
  │   └─────────────────────┘    └─────────────────────────┘    │
  │                                                             │
  └─────────────────────────────────────────────────────────────┘
");
            Console.ResetColor();
        }

        static void MostraBoxInput(string titolo)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"  ╔══════════════════════════════╗");
            Console.WriteLine($"  ║  Inserisci {titolo,-17} ║");
            Console.WriteLine($"  ╚══════════════════════════════╝");
            Console.ResetColor();
        }

        static void MostraRisultato(double numero1, string operazione, double numero2, double risultato, bool singolaCifra)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  ╔══════════════════════════════════════════════════╗");
            Console.WriteLine("  ║                    RISULTATO                     ║");
            Console.WriteLine("  ╠══════════════════════════════════════════════════╣");

            string operazioneStr;
            if (singolaCifra)
                operazioneStr = $"{operazione}({numero1})";
            else
                operazioneStr = $"{numero1} {operazione} {numero2}";

            string risultatoStr = $"  ║  {operazioneStr} = {risultato}";
            risultatoStr = risultatoStr.PadRight(53) + "║";

            Console.WriteLine(risultatoStr);
            Console.WriteLine("  ╚══════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
                    ★ ★ ★ CALCOLO COMPLETATO ★ ★ ★
");
            Console.ResetColor();
        }

        static void MostraErrore(string messaggio)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  ╔══════════════════════════════════════════════════╗");
            Console.WriteLine("  ║                     ERRORE                       ║");
            Console.WriteLine("  ╠══════════════════════════════════════════════════╣");
            string erroreStr = $"  ║  {messaggio}";
            erroreStr = erroreStr.PadRight(53) + "║";
            Console.WriteLine(erroreStr);
            Console.WriteLine("  ╚══════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        static void MostraArrivederci()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
  ╔═══════════════════════════════════════════════════════════════╗
  ║                                                               ║
  ║                      ★ Arrivederci! ★                         ║
  ║                                                               ║
  ╚═══════════════════════════════════════════════════════════════╝
");
            Console.ResetColor();
        }
    }
}
