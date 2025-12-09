#  Estensioni Funzioni Scientifiche - Calcolatrice C#

##  Introduzione
Questa feature estende la versione base della calcolatrice implementando operazioni matematiche di tipo scientifico.  
L'obiettivo è aumentare le funzionalità e rendere la calcolatrice più completa, permettendo di eseguire calcoli più complessi.

Questa estensione è stata implementata in C# in modalità "console application".

---

##  Funzionalità aggiunte

Sono state aggiunte le seguenti operazioni:

###  1) Potenza
- Input: due valori numerici (base e esponente)
- Descrizione: eleva un numero ad un altro
- Formula: `a^b`

###  2) Modulo
- Input: due valori numerici
- Descrizione: restituisce il resto della divisione
- Esempio: `7 % 3 = 1`

###  3) Radice quadrata
- Input: numero (positivo)
- Output: √n
- Gestione errore: se n < 0 → messaggio di errore

###  4) Seno
- Input: numero in radianti
- Funzione utilizzata: `Math.Sin()`

###  5) Coseno
- Input: numero in radianti
- Funzione utilizzata: `Math.Cos()`

###  6) Tangente
- Input: numero in radianti
- Funzione utilizzata: `Math.Tan()`

---

##  Logica implementativa

Per semplificare la gestione delle operazioni:
- Ogni operazione è stata gestita tramite `switch` o struttura simile
- Le funzioni matematiche utilizzano la libreria standard `System.Math`

Esempio generale:
```csharp
double risultato = Math.Pow(a, b);     // Potenza
double resto = a % b;                  // Modulo
double rad = Math.Sqrt(x);             // Radice
double sin = Math.Sin(x);              // Seno
double cos = Math.Cos(x);              // Coseno
double tan = Math.Tan(x);              // Tangente
