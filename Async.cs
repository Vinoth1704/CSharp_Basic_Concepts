using System.Threading.Tasks;
namespace Learn
{
    class Async
    {
        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");
            // Thread.Sleep(TimeSpan.FromSeconds(5));
            // await Task.Delay(TimeSpan.FromSeconds(5));
            await wait();
            Console.WriteLine("\n");
            Console.WriteLine("Some Method End");
        }
        public async static Task<string> wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("1 s completed");
            return "hello";
        }

        public static async void callMethod()
        {
            Task<int> task = method1();
            Method2();
            int count = await task;
            Method3(count);

        }
        public static async Task<int> method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });
            return count;
        }
        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }


        public static void async()
        {
            // Console.WriteLine("Main Method Started......");
            // SomeMethod();
            // Console.WriteLine("Main Method End");
            callMethod();
            Console.ReadKey();
        }
    }
}