using System.Threading;
namespace Learn
{
    class Threads
    {
        public static void Method1()
        {
            for (int i = 0; i < 15; i++)
                Console.WriteLine($"Method 1: {i} and thread name is {Thread.CurrentThread.ManagedThreadId}");
        }
        public static void Method2()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"Method 2: {i} and thread name is {Thread.CurrentThread.ManagedThreadId}");
        }
        public async static void Method3()
        {
            Console.WriteLine("Async starts");
            await Task.Delay(100);
            Console.WriteLine("Async 1 s completed");
            for (int i = 0; i < 5; i++)
                Console.WriteLine($"Method 3: {i} and thread name is {Thread.CurrentThread.ManagedThreadId}");
        }
        public static void Threadss()
        {
            Console.WriteLine("Main thread starts");
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread 1"
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Thread 2"
            }; ;
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread 3"
            }; ;
            t1.Start();
            t2.Start();
            // t3.Start();

        }

    }

}