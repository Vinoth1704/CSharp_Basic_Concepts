namespace Learn
{
    public class Private_Constructor
    {
        public static Private_Constructor? instance;
        // private static int x ;

        private Private_Constructor()
        {
            Console.WriteLine("Private construtor works");
            // x = 10;
            // Console.WriteLine(x);
        }

        public static Private_Constructor getInstance()
        {
            instance = new Private_Constructor();
            return instance;
        }

        public void privateConstructor(){
            
        }
    }
}