namespace Learn
{
    class Loopings
    {
        public void whileLoop()
        {
            int x = 10;
            while (x > 0) //On the first occurance itself while loop checks the condition
            {
                Console.WriteLine("Hello");
                x--;
            }
        }
        public void doWhileLoop()
        {
            int x = 10;
            do
            {
                Console.WriteLine("Hello " + x);
                x--;
            } while (x > 0); // if the condition true or false atleast the loop runs for one time
        }

        public void forLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 5; i++)
                for (int j = 5; j < 10; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
        }


        public static void Looping()
        {
            Loopings loop = new Loopings();
            loop.whileLoop();
            loop.doWhileLoop();
            loop.forLoop();
        }
    }
}