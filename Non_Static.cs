namespace Learn
{
    public class Non_Static
    {
        static string s;
        static Non_Static()
        {
            Console.WriteLine("Static constructor");
        }

        public Non_Static()
        {
            Console.WriteLine("Non-Static constructor");            
        }
    }
}