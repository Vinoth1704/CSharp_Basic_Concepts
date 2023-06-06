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
            Delegates D = new Delegates();
            DisplayName("Alex", D.PrintName);

            Predicate<int> P = new Predicate<int>(IsMinor);
            Console.WriteLine(P(19));
        }

        public void PrintName(string Name)
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

        public static bool IsMinor(int age)
        {
            return age > 18 ? true : false;
        }
    }
}