
namespace Learn
{
    class Basics
    {
        public void Declaration()
        {
            int age = 10; // int32 can hold -2,147,483,648 to 2,147,483,647.
            long number = 100000; // long = int64 it can hold upto -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            double weight = 5.5; //double is used to store decimal values.
            string sentence = "Hello world"; // it can hold multiple characters.
            bool compare = true; // it can hold true or false value.
            char character = 'A'; // it can hold only one char.

            Console.Write(age); // everytime it prints the value in the same line itself.
            Console.Write(weight);
            Console.WriteLine(sentence); // it moves the cursor to next line at the end.
            Console.WriteLine(character);
            Console.WriteLine("The value of int is {0} and the value of long is {1}.", age, number);
            Console.WriteLine("The complier allocates the specified space for the value {1,10}.", age, number); //{,x} x allocates the space for the value.
            Console.WriteLine("The value of int is {0} and the value of long is {1,-10}.", age, number);
            Console.WriteLine($"The value of int is {age} and the value of boolean is {compare}"); // string interpolation.
            Console.WriteLine("The value of char is " + character); // binded strings.

        }

        public void ArthematicOperations()
        {
            int addition = 5 + 5; // result in 10
            int subtraction = 5 - 5; // result in 0
            int multiplication = 5 * 5; // result in 25
            int division = 5 / 5; // result in 1
            int remainder = 5 % 5; // result in 0
            double divisionWithoutDecimal = 45 / 2; // result in 22
            double divisionWithDecimal = 45.0 / 2; // result in 22.5
            Console.WriteLine($"Addition = {addition}");
            Console.WriteLine($"Subtraction = {subtraction}");
            Console.WriteLine($"Multiplication = {multiplication}");
            Console.WriteLine($"Division = {division}");
            Console.WriteLine($"Remainder = {remainder}");
            Console.WriteLine($"Decimal value = {divisionWithoutDecimal}");
            Console.WriteLine($"Decimal value = {divisionWithDecimal}\n");

            int x = 5;
            Console.WriteLine($"The value of the x is {x}");
            x = x + 1;
            Console.WriteLine($"The value of the x when x = x + 1 is{x}");
            x += 1;
            Console.WriteLine($"The value of the x when x += 1 is {x}");
            ++x;
            Console.WriteLine($"The value of the x when ++x is " + x);
            x++;
            Console.WriteLine($"The value of the x when x++ is " + x);

            Console.WriteLine($"The value of the x when ++x is " + ++x);
            Console.WriteLine($"The value of the x when x++ is " + x++);

            int y = x++;
            Console.WriteLine($"The value of the x is {x} and the value of y is {y} when y = x++");

            x = 1; y = 0;
            int z = x / y; // when you try to divide a number by zero it leads to "System.DivideByZeroException: Attempted to divide by zero." exception;
        }

        public void Strings()
        {
            string s = "Hello World";
            Console.WriteLine(s);
            string FirstName = "Steve";
            string SecondName = "Jobs";
            Console.WriteLine($"Full Name = {FirstName + " " + SecondName}");

            // bool nameEquals = FirstName == SecondName; // compares both names using condition operator.
            bool nameEquals = string.Equals(FirstName, SecondName); // compare both names using in-built method.
            Console.WriteLine("If FirstName is equals to SecondName = " + nameEquals);

            int nameEqual = FirstName.CompareTo(SecondName); // it returns 0 is both names are equal or -1 when first name is lesser than second name or 1 when 
            Console.WriteLine("If FirstName is equals to SecondName = " + nameEqual);

            Console.WriteLine($"{FirstName} has {FirstName.Length} characters"); // ".Length" gives you the total length of the string.

            string firstCharacterOfName = FirstName.Substring(0, 1);
            //                                                | |_ _ _ Number of charcter
            //                                                |_ _ _ _ starting point of the string
            Console.WriteLine(firstCharacterOfName);
            string middleSectionOfName = FirstName.Substring(1, 3);
            Console.WriteLine(middleSectionOfName);

            bool startsWith = FirstName.StartsWith("St");
            Console.WriteLine(startsWith);

            Console.WriteLine("If you want to print \" within \"\" then use escape sequence '\\' in front of \" \n"); // Use escape sequence '\' before the special character. 

        }

        public void NumericConversion()
        {
            //There is two types of numeric conversion is available 1.Implicit Conversion, 2.Explicit Conversion.
            //Implicit conversion converts int to double internally by complier (char -> int -> long -> float -> double).
            int number = 5;
            double decimalNumber = number; // number is converted to double by internally.
            Console.WriteLine("Interger is converted to double implicitly and the value is " + decimalNumber);
            // int decimalToInteger = decimalNumber; //You cannot implicitly convert double to int.
            decimalNumber = 5.5;
            int decimalToInteger = (int)decimalNumber; // The decimal number 5.5 is converted to 5.
            Console.WriteLine("Double is converted to int explicitly and the value is " + decimalToInteger);

        }

        enum DayOfWeek
        {
            Sunday, // By default the value of the Sunday is 0 and Monday is 1.
            Monday = 2, // If i change the value of Monday from 1(default) to 2 then the Value of the Tuesday will be 3.  
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        public void Constants()
        {
            const double pi = 3.14;
            //pi=3.41; //If we tries to change the value of the constant it throws an error that constant can't be changed or modified.
            Console.WriteLine("The value of the pi = " + pi);
            DayOfWeek today = DayOfWeek.Tuesday;
            Console.WriteLine("Today is " + today);
            Console.WriteLine((int)today);
            Console.WriteLine((int)DayOfWeek.Tuesday);
        }

        public void Input()
        {
            Console.WriteLine("Enter your First name ");
            string? firstName = Console.ReadLine(); // string? is used to accept nullable value. If it is not used complier warns us that there is possibility of null value and it leads to null reference exception.
            Console.WriteLine("Enter your Second name ");
            string? secondName = Console.ReadLine();
            Console.WriteLine($"Your Fullname is {firstName} {secondName}");

            Console.WriteLine("Enter your age ");
            // int age = int.Parse(Console.ReadLine()); //complier warns that there is possibility of null value.
            int year = Convert.ToInt32(Console.ReadLine());//This is also a type of converting the string into int.
            Console.WriteLine("Your age is " + year);
        }

        public static void Basic()
        {
            Basics b = new Basics();
            b.Declaration();
            b.ArthematicOperations();
            b.Strings();
            b.NumericConversion();
            b.Constants();
            b.Input();
        }
    }
}