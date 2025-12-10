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

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] operazioni = new string[] { "+", "-", "/", "*", "%", "^", "sen", "cos", "tan", "sqrt" };
            string[] operazioniSingolaCifra = new string[] { "sen", "cos", "tan", "sqrt" };
            double primoNumero = 0;
            string operazione = "";
            double secondoNumero = 0;

            // Mostra l'header iniziale
            MostraHeader();
            MostraOperazioniDisponibili();

            do
            {
                try
                {
                    // Input primo numero
                    MostraBoxInput("PRIMO NUMERO");
                    Console.Write("  ➤ ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    primoNumero = double.Parse(Console.ReadLine());
                    Console.ResetColor();

                    // Input operazione
                    MostraBoxInput("OPERAZIONE");
                    Console.Write("  ➤ ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    operazione = Console.ReadLine().ToLower();
                    Console.ResetColor();

                    if (!operazioni.Contains(operazione))
                    {
                        throw new ArgumentException("Operazione non valida!");
                    }

                    double risultato;

                    if (operazioniSingolaCifra.Contains(operazione))
                    {
                        risultato = Core.Operazioni.Calcola(primoNumero, operazione);
                    }
                    else
                    {
                        // Input secondo numero
                        MostraBoxInput("SECONDO NUMERO");
                        Console.Write("  ➤ ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        secondoNumero = double.Parse(Console.ReadLine());
                        Console.ResetColor();

                        risultato = Core.Operazioni.Calcola(primoNumero, secondoNumero, operazione);
                    }

                    // Mostra risultato
                    MostraRisultato(primoNumero, operazione, secondoNumero, risultato, operazioniSingolaCifra.Contains(operazione));

                    // Chiedi se continuare
                    if (!ChiediContinuare())
                        break;

                    Console.Clear();
                    MostraHeader();
                    MostraOperazioniDisponibili();
                }
                catch (FormatException)
                {
                    MostraErrore("Inserisci un numero valido!");
                }
                catch (ArgumentException e)
                {
                    MostraErrore(e.Message);
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
            Console.WriteLine($"  ║  📝 Inserisci {titolo,-14} ║");
            Console.WriteLine($"  ╚══════════════════════════════╝");
            Console.ResetColor();
        }

        static void MostraRisultato(double num1, string op, double num2, double risultato, bool singolaCifra)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  ╔══════════════════════════════════════════════════╗");
            Console.WriteLine("  ║                    RISULTATO                     ║");
            Console.WriteLine("  ╠══════════════════════════════════════════════════╣");

            string operazioneStr;
            if (singolaCifra)
            {
                operazioneStr = $"{op}({num1})";
            }
            else
            {
                operazioneStr = $"{num1} {op} {num2}";
            }

            string risultatoStr = $"  ║  {operazioneStr} = {risultato:F4}";
            risultatoStr = risultatoStr.PadRight(53) + "║";

            Console.WriteLine(risultatoStr);
            Console.WriteLine("  ╚══════════════════════════════════════════════════╝");
            Console.ResetColor();

            // Aggiungi effetto visivo
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
            Console.WriteLine("  ║                   ⚠️  ERRORE ⚠️                    ║");
            Console.WriteLine("  ╠══════════════════════════════════════════════════╣");
            string erroreStr = $"  ║  {messaggio}";
            erroreStr = erroreStr.PadRight(53) + "║";
            Console.WriteLine(erroreStr);
            Console.WriteLine("  ╚══════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        static bool ChiediContinuare()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  ┌─────────────────────────────────────────┐");
            Console.WriteLine("  │  Vuoi fare un altro calcolo? (s/n)     │");
            Console.WriteLine("  └─────────────────────────────────────────┘");
            Console.Write("  ➤ ");
            Console.ResetColor();

            string risposta = Console.ReadLine().ToLower();
            return risposta == "s" || risposta == "si" || risposta == "sì";
        }

        static void MostraArrivederci()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"

  ╔═══════════════════════════════════════════════════════════════╗
  ║                                                               ║
  ║     ██████╗ ██████╗  █████╗ ███████╗██╗███████╗██╗            ║
  ║    ██╔════╝ ██╔══██╗██╔══██╗╚══███╔╝██║██╔════╝██║            ║
  ║    ██║  ███╗██████╔╝███████║  ███╔╝ ██║█████╗  ██║            ║
  ║    ██║   ██║██╔══██╗██╔══██║ ███╔╝  ██║██╔══╝  ╚═╝            ║
  ║    ╚██████╔╝██║  ██║██║  ██║███████╗██║███████╗██╗            ║
  ║     ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚══════╝╚═╝            ║
  ║                                                               ║
  ║                  ★ Arrivederci! ★                             ║
  ║                                                               ║
  ╚═══════════════════════════════════════════════════════════════╝

");
            Console.ResetColor();
        }
    }
}
