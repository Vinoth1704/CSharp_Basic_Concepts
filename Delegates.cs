namespace Learn
{
    public class Delegates
    {
        public delegate void PrintNameDelegate(string Name);
        public static void Delegate()
        {
            // PrintNameDelegate del = new PrintNameDelegate(PrintName);
            // del += PrintFullName;
            // del("Alex");
            DisplayName("Alex", PrintName);
        }

        public static void PrintName(string Name)
        {
            Console.WriteLine(Name);
        }
        public static void PrintFullName(string Name)
        {
            Console.WriteLine($"FullName : {Name} ");
        }

        public static void DisplayName(string Name, PrintNameDelegate print)
        {
            print(Name);
        }
    }
}