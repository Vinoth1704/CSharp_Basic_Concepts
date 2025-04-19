namespace Learn
{
    class Arrays
    {
        public void Declaraction()
        {
            int[] array = new int[2];
            array[0] = 1;
            array[1] = 2;
            Console.WriteLine(array[1]);

            int[] array2 = new int[3] { 1, 2, 3 };
            int[] array3 = new int[] { 1, 2, 3 };
            int[] array4 = { 1, 2, 3 }; //short hand method.
        }

        public void loopInArray()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 10;
                Console.WriteLine(array[i]);
            }

            //Foreach loop is read-only
            foreach (int number in array)
            {
                //number+=3; // Unlike the for loop, the iteration variable in a foreach loop is read-only.
                // Attempting to assign a value to the variable within the body of the loop will result in a compile-time error.
                Console.WriteLine(number);
            }
        }

        public void searchingInArray()
        {
            string[] students = { "Sam", "David", "Henry", "Steve", "Ford" };
            bool found = false;
            Console.WriteLine("Enter the name of the student to be searched : ");
            string? studentName = Console.ReadLine();
            for (int i = 0; i < students.Length; i++)
            {
                if (studentName == students[i])
                {
                    found = true;
                    break; // Break statement is used to stop the loop when the student name is found. 
                }
            }
            if (found)
                Console.WriteLine("Student found");
            else
                Console.WriteLine("Student not found");

        }

        public void arrayMethods()
        {
            //Binary search
            int[] sortedNumbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            Console.WriteLine("Enter the number to be find : ");
            int numberToBeFind = Convert.ToInt32(Console.ReadLine());
            int answer = Array.BinarySearch(sortedNumbers, numberToBeFind);
            if (answer >= 0)
                Console.WriteLine("Given number is found in {0} index", answer);
            else
                Console.WriteLine("Given number is not found in the array or array is not sorted.");

            //Sorting
            int[] numbers = { 10, 20, 80, 60, 50, 20, 70, 30, 90 };
            Array.Sort(numbers);
            foreach (int number in numbers)
                Console.WriteLine(number);

            //Reversing the array
            int[] reverseNumbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            Array.Reverse(sortedNumbers);
            foreach (int number in sortedNumbers)
                Console.Write(number + " ");
        }

        public void multiDimensionalArray()
        {
            //Normal multi dimensional array
            int[,] twoDimensionalArray = new int[3, 3];
            twoDimensionalArray[0, 0] = 1;
            twoDimensionalArray[0, 1] = 2;
            twoDimensionalArray[0, 2] = 3;

            twoDimensionalArray[1, 0] = 4;
            twoDimensionalArray[1, 1] = 5;
            twoDimensionalArray[1, 2] = 6;

            twoDimensionalArray[2, 0] = 7;
            twoDimensionalArray[2, 1] = 8;
            twoDimensionalArray[2, 2] = 9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(twoDimensionalArray[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] twoDimensionalArray1 = { { 7, 8, 9 }, { 4, 5, 6 }, { 1, 2, 3 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(twoDimensionalArray1[i, j] + " ");
                Console.WriteLine();
            }

            //Jagged array
            Console.WriteLine("Jagged array");
            int[][] JaggedArray = new int[3][];
            JaggedArray[0] = new int[2] { 1, 2 };
            JaggedArray[1] = new int[3] { 1, 2, 3 };
            JaggedArray[2] = new int[]{ 5, 6 };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < JaggedArray[i].Length; j++)
                    Console.Write(JaggedArray[i][j] + " ");
                Console.WriteLine();
            }

        }

        public static void Arrayss()
        {
            Arrays a = new Arrays();
            a.Declaraction();
            a.loopInArray();
            a.searchingInArray();
            a.arrayMethods();
            a.multiDimensionalArray();
        }
    }
}