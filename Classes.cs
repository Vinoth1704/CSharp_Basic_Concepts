namespace Learn
{
    class Students
    {
        public string? name; //Properties of the class.
        public int rollNumber;
        public double score;

        public void showScoreCard()
        {
            Console.WriteLine($"\nName : {name}\nRoll number : {rollNumber}\nScore : {score}");
        }
    }

    class Employees
    {
        private string? name;
        private int age;
        private int employeeNumber;

        //Constructor
        public Employees(string name, int age, int employeeNumber)
        {
            this.name = name; // Here "this" keyword refers to the current class.
            this.age = age;
            this.employeeNumber = employeeNumber;
        }
        // public Employees(string name, int age)
        // {
        //     this.name = name;        -->//Here to avoid the code duplication below method can be used.
        //     this.age = age;   
        // }
        public Employees(string name, int age) : this(name, age, 0)
        {
        }

        //Get and Set methods

        // public string GetName()
        // {
        //     return name!;
        // }
        // public string GetName() => name!; //Short hand method for the above method.

        public string GetName()
        {
            if (age > 25)
            {
                return name!;
            }
            else
            {
                return "Employee is too young";
            }
        }

        // public void SetName(string name) => this.name = name;

        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.name = name;
            }
            else
            {
                Console.WriteLine("Name can't be null or empty");
            }
        }

        //Properties
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name!;
            }

        }


        public void showEmployeeDetails()
        {
            Console.WriteLine($"\nEmployeeNumber : {employeeNumber}\nName : {name}\nAge : {age}");
        }

    }

    class Classes
    {
        public static void Class()
        {
            Students s1 = new Students();
            s1.name = "Albert";
            s1.rollNumber = 1;
            s1.score = 71.18;
            s1.showScoreCard();

            Students s2 = new Students();
            s2.name = "John";
            s2.rollNumber = 2;
            s2.score = 90;
            s2.showScoreCard();

            //Constructors
            Employees e1 = new Employees("Mike", 21, 1);
            e1.showEmployeeDetails();
            Employees e2 = new Employees("Sam", 22);
            e2.showEmployeeDetails();

            //Properties
            e1.Name = "Tom";
            Console.WriteLine(e1.Name);

        }
    }
}