namespace Learn
{
    class DecisionMakings
    {
        public void ifStatement()
        {
            int number = 5;
            if (number > 5)
                Console.WriteLine("The given number is greater than 5");//If statement consider only the next line when it is not enclosed with {}.
            Console.WriteLine("Hello");//This is not considered under the if statement.

            if (number > 10)
            {
                Console.WriteLine("The given number is greater than 10");
                Console.WriteLine("Congratulations");
            }

            Console.WriteLine("Enter your age ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("Congrats!! now you are ready vote");
            }
        }

        public void ifElseStatement()
        {
            Console.WriteLine("Enter your age ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18) //if given age is greater than 18 this block will execute
            {
                Console.WriteLine("Congrats!! now you are ready vote");
            }
            else if (age == 18)//if given age is equals to 18 this block will execute
            {
                Console.WriteLine("Wow you are perfect 18 now");
            }
            else //if both condition fails the else condition will execute
            {
                Console.WriteLine("You are lesser than 18");
            }
        }

        public void compoundStatement()
        {
            Console.WriteLine("Enter your age ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18 && age < 55) //Both the condition to be true
            {
                Console.WriteLine("You are eligible");
            }
            if (age < 18 || age > 55) //Either one of the condition wants to be true
            {
                Console.WriteLine("You are not eligible");
            }
        }

        public void switchStatement()
        {
            Console.WriteLine("Enter a number between 1 to 3");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("One");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Two");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Three");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong number");
                        break;
                    }

            }
        }

        public void ternaryOperator()
        {
            //condition ? true : false;
            int x = 10, y = 20;
            int greaterNumber = x > y ? x : y;
            Console.WriteLine("The greatest number is " + greaterNumber);
            double score = 94.5;
            Console.WriteLine((score > 50) ? "Pass" : "Fail");
        }

        public static void DecisionMaking()
        {
            DecisionMakings dm = new DecisionMakings();
            dm.ifStatement();
            dm.ifElseStatement();
            dm.compoundStatement();
            dm.switchStatement();
            dm.ternaryOperator();
        }
    }
}