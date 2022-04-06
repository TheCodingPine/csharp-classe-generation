/* 
nomi
cognomi
eta
numero di partecipanti attuali nel corso

Testate le vostre funzioni di statistiche, per esempio aggiungendo l'opzione "statistiche" per l'utente, che una volta scritto a console "statistiche" vi stampi i risultati delle funzioni appena dichiarate.
*/


string[] nomiAlunni = new string[10]; //array di stringhe dimensione 10
string[] cognomiAlunni = new string[10];
string[] etaAlunni = new string[10];
int indiceDiTutto = 0;

//proviamo: voglio salvare l'enumeratore più vecchio, giovane e con più lettere ad ogni aggiunta, per recuperarli poi
int theOldestPartecipante = 0;
int theYoungestPartecipante = 0;

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
    Console.WriteLine("L'ultimo alunno è " + indiceDiTutto);
    if (indiceDiTutto == 0)
    {
        Console.WriteLine("Non sono presenti alunni");
    }
    else
    {
        indiceDiTutto--; // i--
        //sbianca tutto
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
            Console.WriteLine("Età alunno (cifra): ");
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