
namespace Learn
{
    class ExceptionHandlings
    {
        public int DivideByZero()
        {
            int x = 5, y = 0, z = 0;
            // if (y == 0)
            // {
            //     throw new DivideByZeroException("The dividend can't be zero.");
            // }
            // else
            // {
            //     z = x / y;
            // }

            try
            {
                z = x / y;
                return z;
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
                return 0;
                // throw new DivideByZeroException("The dividend can't be zero.");
            }
            finally
            {
                Console.WriteLine("Finally block executed successfully");
            }
        }
        public static void ExceptionHandling()
        {
            ExceptionHandlings EH = new ExceptionHandlings();
            int n =EH.DivideByZero();
        }
    }
}