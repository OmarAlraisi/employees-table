namespace EmployeeTableApplication
{

    class App
    {

        static void performCRUD(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Creating a new employee");
                    break;
                case 2:
                    Console.WriteLine("Reading employee's info");
                    break;
                case 3:
                    Console.WriteLine("Updating employee's info");
                    break;
                case 4:
                    Console.WriteLine("Deleting employee");
                    break;
                default:
                    // This is not possible because validation is already done.
                    break;
            }
        }

        static int getValidInput()
        {
            Console.Write("Select an operation (1 - 4): ");
            while (true)
            {
                string input = Console.ReadLine()!;
                int choice;
                if (!int.TryParse(input, out choice)) { Console.Write("Invalid input, please enter an integer: "); continue; }
                if (choice < 1 || choice > 4) { Console.Write("Invalid input, please enter a value between (1 - 4): "); continue; }
                return choice;
            }
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("This is Employees Table Application");
            // Console.WriteLine(
            //     "CRUD Operations:\n1. Create Employee.\n2. Read employee's information.\n3. Update employee's information.\n4. Delete employee."
            // );
            // int choice = getValidInput();

            // performCRUD(choice);


        }
    }
}