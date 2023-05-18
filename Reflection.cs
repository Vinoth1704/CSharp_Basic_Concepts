namespace Learn
{
    public class Reflection
    {
        static string s="Hello";
        public static void Reflections()
        {
            Console.WriteLine("Type : "+s.GetType());
        }
    }
}