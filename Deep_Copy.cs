namespace Learn
{
    public class Deep_Copy
    {
        public static void Deep_Copy_Main()
        {
            Employee emp1 = new Employee();
            emp1.employeeId = 1;
            emp1.employeeName = "Alex";
            emp1.employeeAddress = new Address() { address = "Chennai" };

            Employee emp2 = emp1.GetClone();
            emp2.employeeId = 2;
            emp2.employeeName = "Bob";
            emp2.employeeAddress!.address="Coimbatore";
            // emp2.employeeAddress = new Address() { address = "Chennai" };

            Console.WriteLine($"ID : {emp1.employeeId} \nName : {emp1.employeeName} \nAddress : {emp1.employeeAddress.address}");
            Console.WriteLine($"ID : {emp2.employeeId} \nName : {emp2.employeeName} \nAddress : {emp2.employeeAddress.address}");
        }
    }
}