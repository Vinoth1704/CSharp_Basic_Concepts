using System.Threading.Tasks;
namespace Learn
{
    class Asynchoronus
    {
        public async static Task asyncLoop()
        {
            Console.WriteLine("Before await function");
            // await Task.Delay(5000);
            await wait();
            Console.WriteLine("After await function");
        }

        public async static Task<string> wait()
        {
            await Task.Delay(1);
            Console.WriteLine("1 s completed");
            return "hello";
        }

        public static void loop()
        {
            // await Task.Delay(1000);
            for (int i = 0; i < 10000; i++)
                i++;
        }
        public async static void ASynchoronus()
        {
            await asyncLoop();
            loop();
            for (int i = 0; i < 20; i++)
                Console.Write(i + " ");
            Console.Read();
        }


    }
}