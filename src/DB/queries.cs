namespace EmployeeTableApplication
{
    class BackendQueries : Backend
    {
        public Employee[] getAllEmployees()
        {
            return employees;
        }

        public Employee? getEmployeeByID(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.id == id) return emp;
            }
            return null;
        }
    }
}