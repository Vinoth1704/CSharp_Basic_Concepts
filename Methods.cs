namespace Learn
{
    class First //Every method should be written inside the class
    {
        public void publicPrint()
        // |     |       |_ _ _ _ _ _ Method Name. 
        // |     |_ _ _ _ _ _ _ _ _ _ Return type (int, string, bool, etc..). void mean null.
        // |_ _ _ _ _ _ _ _ _ _ _ _ _ Access specifier (Private, Protected, Public). public method can be accessed outside the class.
        {
            Console.WriteLine("Public method");
        }
        private void privatePrint() // Private method can be only accessed within the class.
        {
            Console.WriteLine("Private method");
        }

        public void print()
        {
            First fun = new First();
            fun.privatePrint();
            int sum = staticAdd(10, 30);
            Console.WriteLine("sum = " + sum);
        }

        public int add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int staticAdd(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    class Methods
    {
        public static void callByValue(int number)
        {
            number += 10;
            Console.WriteLine($"Value of number inside function {number}");
        }
        public static void callByReference(int[] numbers)
        {
            numbers[0] += 10;       //By default array is a reference type if we modify a value inside array it will reflect outside of the method
            numbers = new int[]{2}; //Re-assigning the array won't change base array.
            Console.WriteLine($"Value of number inside function {numbers[0]}");
        }

        public static void refKeyword(ref int age)
        {
            age += 1;
        }

        public static void outKeyword(int num1, int num2, out int add, out int product)
        {
            add = num1 + num2;
            product = num1 * num2;
        }

        public static void paramsMethod(params int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine(nums[i] + " ");
        }

        public static void Add(int num1, int num2)
        {
            Console.WriteLine("sum is {0}", num1 + num2);
        }
        public static void Add(string firstName, string secondName)
        {
            Console.WriteLine($"Full Name is {firstName} {secondName}");
        }
        public static void Sum(int num1, int num2 = 1, int num3 = 2)
        {
            int answer = num1 + num2 + num3;
            Console.WriteLine("The answer is " + answer);
        }

        public static void Method()
        //        |_ _ _ _ _ _ _ _ _ _ _ When the static keyword is used that method did not required any object to initiate. It can be directly called.
        {
            First f = new First(); // Here First is class name. f is the object name for the class First.
            f.publicPrint();
            Console.WriteLine("Non-static method sum = " + f.add(10, 20));
            int sum = First.staticAdd(10, 20); //Calling the static methods directly using the class name
            Console.WriteLine("Static method sum = {0}", sum);

            //Call by value
            int number = 10;
            Console.WriteLine($"Value of number before function {number}");
            callByValue(number);
            Console.WriteLine($"Value of number after function {number}");

            //Call by reference
            int[] numbers = { 1 };
            Console.WriteLine($"Value of number before function {numbers[0]}");
            callByReference(numbers);
            Console.WriteLine($"Value of number after function {numbers[0]}");

            //ref keyword
            int age = 21; //ref keyword needs initailization
            Console.WriteLine($"Value of age before function {age}");
            refKeyword(ref age); //ref keyword takes the value along with the location of the value
            Console.WriteLine($"Value of age after function {age}");

            //out keyword
            int num1 = 10, num2 = 20, add, product; //out keyword does not require initialization
            outKeyword(num1, num2, out add, out product); // out keyword can be used when we need a multiple return type
            Console.WriteLine($"The value of the sum={add} and product={product}");

            //params
            // int[] nums = { 1, 2, 3, 4 };
            int n = 10;
            paramsMethod(1, 2, 3, 5);
            paramsMethod(n);

            //Method Overloading
            Add(3, 5);
            Add("Steve", "Jobs");

            //Optional parameter
            Sum(1, 2, 3);
            Sum(1, 2);
            Sum(1, num3: 2);
            Sum(num3: 10, num2: 5, num1: 12);
        }

    }

}