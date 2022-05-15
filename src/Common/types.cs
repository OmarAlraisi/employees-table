namespace EmployeeTableApplication
{
    struct Employee
    {
        public int id;
        public string fullName;
        public int dob; // Convert from date format to a number '10-05-1996' --> '19960510'
        public double salary;
        public string ifsID;

        public Employee()
        {
            id = 0;
            fullName = "";
            dob = 0;
            salary = 0;
            ifsID = "";
        }
    }
}