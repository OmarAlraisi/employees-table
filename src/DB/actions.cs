namespace EmployeeTableApplication
{
    // Move these actions to affect the SQL server
    class BackendActions : Backend
    {
        public void createEmployee(string name, int dateOB, double sal, string ifs)
        {
            if (numberOfRegisteredEmployees > 4) return;
            int index = numberOfRegisteredEmployees;
            employees[index].fullName = name;
            employees[index].dob = dateOB;
            employees[index].salary = sal;
            employees[index].ifsID = ifs;
            numberOfRegisteredEmployees++;
        }

        // The ID is no longer usable due to the code's logic
        public void deleteEmployeeByID(int id)
        {
            int i = id - 1;
            employees[i] = new Employee();
            employees[i].id = id;
        }
    }
}