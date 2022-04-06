/* 
questo punto volete avere delle statistiche sulla vostra classe, pertanto vi si chiede di
fornire tramite funzioni le seguenti cose:
una funzione calcolaEtaMediaClasse che vi restituisca l'età media della classe.
una funzione EtaPiuGiovane che vi restituisce l'età dell'alunno più giovane in classe.
una funzione EtàPiuVecchio che vi restituisce l'età dell'alunno più vecchio.
*/


string[] nomiAlunni = new string[10]; //array di stringhe dimensione 10
string[] cognomiAlunni = new string[10];
string[] etaAlunni = new string[10];
byte indiceDiTutto = 0;

//proviamo: voglio salvare l'enumeratore più vecchio, giovane e con più lettere ad ogni aggiunta, per recuperarli poi
byte theOldestPartecipante = 0;
byte theYoungestPartecipante = 0;

// --------------------------FUNZIONI--------------------------

//Stampacognomi

//stampanome

//stampaetà

//aggiungiAlunno

void AggiungiAlunno(string nome, string cognome, string eta)
{
    if (indiceDiTutto < 9)        
    {
        nomiAlunni[indiceDiTutto] = nome;
        cognomiAlunni[indiceDiTutto] = cognome;
        etaAlunni[indiceDiTutto] = eta;
        indiceDiTutto++;
    } else
    {
        Console.WriteLine("Hai raggiunto i dieci iscritti! Rimuovi l'ultimo alunno.");
    }
}

//rimuoviAlunno

void RimuoviAlunno()
{
    Console.WriteLine("Rimosso " + nomiAlunni[indiceDiTutto -1] + " " + cognomiAlunni[indiceDiTutto -1]);
    if (indiceDiTutto == 0)
    {
        Console.WriteLine("Non sono presenti alunni");
    }
    else
    {
        indiceDiTutto--; // i--
        nomiAlunni[indiceDiTutto] = ("");
        cognomiAlunni[indiceDiTutto] = "";
        etaAlunni[indiceDiTutto] = "";
        if (indiceDiTutto != 0)
        { 
            Console.WriteLine("Ora l'ultimo alunno è " + nomiAlunni[indiceDiTutto-1] + " " + cognomiAlunni[indiceDiTutto-1]);
        }
    }
}


//cicloFor degli iscritti

void RicapitolandoGliIscritti()
{
    for (int i = 0; i < indiceDiTutto; i++)
    {
        Console.WriteLine(nomiAlunni[i] + " " + cognomiAlunni[i] + ", di anni " + etaAlunni[i]);
    }
}


//-----------------------FUNZIONI AVANZATE----------------------


//calcola età media classe

//the Oldest

//the Youngest



//-------------------------------------------------------------
//---------------------L'ESEGUIBILE----------------------------
//-------------------------------------------------------------

Console.WriteLine("Attualmente la classe è composta da " + indiceDiTutto + " alunni.");

while (true)
{
    Console.Write("Vuoi aggiungere un alunno dalla lista o rimuovere l'ultimo aggiunto? [aggiungi/rimuovi/lista]");
    string risposta = Console.ReadLine();

    switch (risposta)
    {
        case "aggiungi":
            Console.Write("Nome alunno: ");
            string nome = Console.ReadLine();
            Console.Write("Cognome alunno: ");
            string cognome = Console.ReadLine();
            Console.Write("Età alunno (cifra): ");
            string eta = Console.ReadLine();
            AggiungiAlunno(nome, cognome, eta);
            break;
        case "rimuovi":
            RimuoviAlunno();
            break;
        case "lista":
            Console.WriteLine("Gli iscritti attuali sono: ");
            RicapitolandoGliIscritti();
            break;
        default:
            Console.WriteLine("Errore di battitura.");
            break;
    }
}