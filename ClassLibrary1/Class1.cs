namespace ClassLibrary1
{
    public static class Utility
    {
        public static StreamWriter WrtieAttempt()
        {
            Console.WriteLine("ATTEMPTING FILE OPENING");
            StreamWriter developerActivity;
            try
            {
                Console.WriteLine("FILE OPENED");
                return developerActivity = File.AppendText("C:\\boolean\\classe 56\\.Net\\csharp-client-simulator\\developer-activity.txt");
            }
            catch (IOException)
            {
                Console.WriteLine("COULD NOT OPEN");
                return WrtieAttempt();
            }

        }

        public static StreamReader ReadAttempt()
        {
            StreamReader developerActivity;
            Console.WriteLine("ATTEMPTING FILE OPENING");

            try
            {
                Console.WriteLine("FILE OPENED");
                return developerActivity = File.OpenText("C:\\boolean\\classe 56\\.Net\\csharp-client-simulator\\developer-activity.txt");
            }
            catch (IOException)
            {
                Console.WriteLine("COULD NOT OPEN");
                return ReadAttempt();
            }

        }
    }
}