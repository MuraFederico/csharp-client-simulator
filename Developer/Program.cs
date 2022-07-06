//lo sviluppatore legge le attività dal suo file di attività (developer_activity) da risolvere
//per risolvere le attività ci impega dai 3 ai 15 secondi
//se le risolve le elimina dalla lista
//se non le risolve la porta in fondo alla lista per farle in un secondo momento


//1. creare il reader 
//2. aprire il file developer_activity.txt

//3. leggo la riga = task ??? 

//4. bool risolta = true || false --> new Random().NextDouble() > 0.5;

//5. risolta == false --> dobbiamo scrivere il file di modo che l'ultima riga sia il task corrente.
//5.1 risolta == true --> dobbiamo scrivere il file in modo che la lista sia aggiornata senza il task corrente.

//6. ripeto dal punto ?? 



using ClassLibrary1;



/*List<string> completedTasks = new List<string>();
List<string> pendingTasks = new List<string>();*/


/*foreach (string activity in developerActivityList)
{
    Console.WriteLine($"presa in carico di {activity}");
    Thread.Sleep(new Random().Next(3000,15001));

    if(new Random().NextDouble() > 0.5)
    {
        completedTasks.Add(activity);
    }
    else
    {
        pendingTasks.Add(activity);
    }
}*/

int i = 0;

UpdateActivity(i);



void UpdateActivity(int i)
{
    
    string[] developerActivity = File.ReadAllLines("C:\\boolean\\classe 56\\.Net\\csharp-client-simulator\\developer-activity.txt");

    List<string> developerActivityList = developerActivity.ToList();
    Console.WriteLine("tentativo presa in carico");
    if (developerActivityList.Count > 0)
    {
        string activity = developerActivityList[0];
        if (activity != "")
        {
            Console.WriteLine($"presa in carico di {activity}");
            Thread.Sleep(new Random().Next(3000, 15001));

            if (new Random().NextDouble() > 0.5)
            {
                developerActivityList = File.ReadAllLines("C:\\boolean\\classe 56\\.Net\\csharp-client-simulator\\developer-activity.txt").ToList();
                developerActivityList.Remove(activity);
                File.WriteAllLines("C:\\boolean\\classe 56\\.Net\\csharp-client-simulator\\developer-activity.txt", developerActivityList);
                Console.WriteLine("task completed");
            }
            else
            {
                developerActivityList = File.ReadAllLines("C:\\boolean\\classe 56\\.Net\\csharp-client-simulator\\developer-activity.txt").ToList();
                developerActivityList.Remove(activity);
                developerActivityList.Add(activity);
                File.WriteAllLines("C:\\boolean\\classe 56\\.Net\\csharp-client-simulator\\developer-activity.txt", developerActivityList);
                Console.WriteLine("task delayed");
            }
        }
        else
        {
            Console.WriteLine("task non valida");
            developerActivityList.Remove(activity);
            File.WriteAllLines("C:\\boolean\\classe 56\\.Net\\csharp-client-simulator\\developer-activity.txt", developerActivityList);
        }
    }
    else
    {
        Console.WriteLine("lista task vuota");
        i++;
    }


    if(i > 100)
    {
        return;
    }
    Thread.Sleep(500);
    UpdateActivity(i);
}