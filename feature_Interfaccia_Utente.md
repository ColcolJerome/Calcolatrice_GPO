# Interfaccia Utente – Modalità Testuale

## Obiettivo della feature
La seguente feature implementa un’interfaccia utente testuale (console UI) che permette all’utente di interagire con la calcolatrice in modo chiaro e guidato.  
L’interfaccia presenta le operazioni disponibili, richiede specificamente gli input e gestisce le eccezioni in modo esplicito.

L’obiettivo è migliorare significativamente l’esperienza utente rispetto a una semplice sequenza di richieste input-output, rendendo lo strumento più leggibile, intuitivo e professionale.

---

## Funzionalità principali

### Presentazione delle operazioni
La console mostra un menù suddiviso in due categorie:
- Operazioni base: addizione, sottrazione, moltiplicazione, divisione e modulo
- Operazioni avanzate: seno, coseno, tangente, radice quadrata e potenza

Ogni operazione è accompagnata da una descrizione testuale che ne chiarisce l’utilizzo.

### Inserimento guidato degli input
L’interfaccia richiede in sequenza:
1. Primo numero
2. Operazione
3. Secondo numero (solo quando necessario)

Ogni richiesta è incorniciata graficamente per essere chiaramente riconoscibile.

### Visualizzazione degli errori
Gli errori o input non validi vengono segnalati esplicitamente tramite un’area dedicata, identificata dal messaggio:
"Generata eccezione di tipo 'Calcolatrice.Core.NotAnOperationExeption'."

Ciò consente all’utente di comprendere gli errori in tempo reale e inserire valori corretti in seguito.

### Stile grafico nella console
L’interfaccia mostra una schermata strutturata con:
- Titolo ASCII art
- Bordature per separare sezioni logiche
- Tabelle per la classificazione delle operazioni
- Colorazione tramite escape codes o librerie ANSI
- Spaziatura calibrata per migliorare leggibilità

Questo layout consente di offrire un aspetto coerente e gradevole su terminale.

---

## Motivazioni della scelta
La versione testuale è stata preferita rispetto alla versione Windows Forms per garantire:
- portabilità
- compatibilità con sistemi multipiattaforma
- maggiore controllo nella gestione dell’input
- possibilità di fornire messaggi personalizzati

Inoltre, costituisce una base solida per future estensioni, come integrazione con interfacce grafiche vere e proprie o versioni web.

---

## Gestione delle eccezioni
Per operazioni non valide o per input non previsto, viene sollevata l’eccezione personalizzata `NotAnOperationExeption`.  
L’interfaccia intercetta e visualizza l’errore, richiedendo nuovamente un input valido.

La gestione delle eccezioni evita crash del programma e migliora l’affidabilità dell’applicativo.

---

## Stato della feature
La feature è stata completata e integrata nella versione corrente della calcolatrice.  
Ulteriori miglioramenti futuri possibili:
- Introduzione di un sistema di storico delle operazioni
- Colorazione differenziata in base al tipo di messaggio (input, risultato, errore)
- Menu interattivi avanzati

---
