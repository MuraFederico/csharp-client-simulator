//il cliente assegna delle attività allo svilppatore (dal suo file al file dello sviluppatore).

//questa attività avviene casualmente in un intervallo di 5-10 secondi; ( Thread.Sleep(1000) );

//qualce volta perà il cliente viene distratto (il programma si chiude casualmente? - oppure c'è un'eccezione)

//quindi il cliente deve ricominciare possibilmente senza riassegnare task già assegnati allo sviluppatore ( che controlli ?? )



//sviluppi


//1.    creare i reader e i writer per leggere dal file
//      C:\Users\mistre\source\repos\csharp-developer-simulator\client_activity.txt
//      al file C:\Users\mistre\source\repos\csharp-developer-simulator\developer_activity.txt
//      dovremmo fare una apertura in lettura di un file e in scrittura di un altro file

//2. leggere la linea = attività e salvarala da qualche parte --> read su client_activity.txt
//3. scrivere l'attivà che abbiamo recuperato nell'atro file --> write su developer_activity.txt

//4. Tread.Sleep(...tot secondi casuali...)

//5. si ricomincia da punto 2 fino alla fine del file client_activity.txt

using ClassLibrary1;

StreamReader clientActivity = File.OpenText("C:\\boolean\\classe 56\\.Net\\csharp-client-simulator\\client-activity.txt");
string[] assignedTasks = File.ReadAllLines("C:\\boolean\\classe 56\\.Net\\csharp-client-simulator\\developer-activity.txt");



while (!clientActivity.EndOfStream)
{
    string activity = clientActivity.ReadLine();
    
    if (!assignedTasks.Contains(activity))
    {
        AssignTask(activity);
        
    }

    assignedTasks = File.ReadAllLines("C:\\boolean\\classe 56\\.Net\\csharp-client-simulator\\developer-activity.txt");
}

clientActivity.Close();

void AssignTask(string activity)
{
    StreamWriter developerActivity = Utility.WrtieAttempt();
    developerActivity.WriteLine(activity);
    developerActivity.Close();
    Console.WriteLine($"assigned activity {activity}");
    Thread.Sleep(new Random().Next(5000, 10001));
}