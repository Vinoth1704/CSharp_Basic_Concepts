
namespace Learn
{
    class ExceptionHandlings
    {
        public void DivideByZero()
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
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
                // throw new DivideByZeroException("The dividend can't be zero.");
            }
        }
        public static void ExceptionHandling()
        {
            ExceptionHandlings EH = new ExceptionHandlings();
            EH.DivideByZero();
        }
    }
}