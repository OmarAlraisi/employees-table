namespace EmployeeTableApplication
{
    class Backend
    {
        protected int numberOfRegisteredEmployees = 0;
        protected static Employee[] employees = new Employee[5];

        // Give IDs to employees
        protected Backend()
        {
            for (int i = 0; i < 5; i++)
            {
                employees[i].id = i + 1;
            }
        }
    }
}