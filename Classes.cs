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

    class BankAccount
    {
        private string? name;
        private double balance;

        public BankAccount(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public string Name
        {
            get
            {
                return name!;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
        }

        public static BankAccount operator +(BankAccount bank1, BankAccount bank2)
        {
            string newAccountName = bank1.name + bank2.name;
            double newBalance = bank1.balance + bank2.balance;
            BankAccount newAccount = new BankAccount(newAccountName, newBalance);
            return newAccount;
        }
        public static BankAccount operator +(BankAccount bank1, double balance)
        {
            string newAccountName = bank1.name!;
            double newBalance = bank1.balance + balance;
            BankAccount newAccount = new BankAccount(newAccountName, newBalance);
            return newAccount;
        }
        public static BankAccount operator -(BankAccount bank1, BankAccount bank2)
        {
            string newAccountName = bank1.name + bank2.name;
            double newBalance = bank1.balance - bank2.balance;
            BankAccount newAccount = new BankAccount(newAccountName, newBalance);
            return newAccount;
        }
    }

    class Person
    {
        private string? name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

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

        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age!;
            }
        }

        public static void changeName(Person p)
        {
            p.name = "Steve";
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

            //Operator overloading
            BankAccount bank1 = new BankAccount("Frank", 100);
            BankAccount bank2 = new BankAccount("Steve", 200);
            BankAccount bank3 = bank1 + bank2;
            Console.WriteLine("Bank 3" + bank3.Name + " " + bank3.Balance);
            BankAccount bank5 = bank3 + 500;
            Console.WriteLine("Bank 5" + bank5.Name + " " + bank5.Balance);
            BankAccount bank4 = bank2 - bank1;
            Console.WriteLine("Bank 4" + bank4.Name + " " + bank4.Balance);

            //Passing object to methods
            Person p1 = new Person("Frank", 25);
            Console.WriteLine($"Before changing name = {p1.Name}");
            Person.changeName(p1);
            Console.WriteLine($"After changing name = {p1.Name}");

        }
    }
}