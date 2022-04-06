/* 
nomi
cognomi
eta
numero di partecipanti attuali nel corso

Testate le vostre funzioni di statistiche, per esempio aggiungendo l'opzione "statistiche" per l'utente, che una volta scritto a console "statistiche" vi stampi i risultati delle funzioni appena dichiarate.
*/


string[] nomiAlunni = new string[10]; //array di stringhe dimensione 10
string[] cognomiAlunni = new string[10];
string[] etàAlunni = new string[10];
int partecipantiNow = 0;

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
    if (partecipantiNow < 9)        
    {
        nomiAlunni[partecipantiNow] = nome;
        cognomiAlunni[partecipantiNow] = cognome;
        etàAlunni[partecipantiNow] = Int32.Parse(eta);
        partecipantiNow++;
    } else
    {
     
    }
}

//rimuoviAlunno

void RimuoviAlunno(string nome, string cognome, string eta)
{
    if (partecipantiNow = 0)
    {
        Console.WriteLine("Non sono presenti alunni");
    }
    else
    {
        partecipantiNow--; // i--
        //sbianca tutto
    }
}


//-----------------------FUNZIONI AVANZATE----------------------


//calcola età media classe

//the Oldest

//the Youngest



//-------------------------------------------------------------
//---------------------L'ESEGUIBILE----------------------------
//-------------------------------------------------------------

Console.WriteLine("Attualmente la classe è composta da " + partecipantiNow + " alunni.");

while (true)
{
    Console.Write("Vuoi aggiungere o rimuovere un alunno dalla lista? [aggiungi/rimuovi]");
    string risposta = Console.ReadLine();

    switch (risposta)
    {
        case "aggiungi":
            Console.Write("Nome alunno: ");
            string

            break;
        case "rimuovi";
            RimuoviAlunno();
            break;
        default:
            Console.WriteLine("Errore di battitura.");
            break;
    }
}