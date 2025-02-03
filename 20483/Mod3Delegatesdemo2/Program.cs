namespace Mod3Delegatesdemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Eid = 1, Name = "Nathan", YearsOfExp = 2, Grade = 'A' });
            employees.Add(new Employee() { Eid = 2, Name = "Sherry", YearsOfExp = 6, Grade = 'B' });
            employees.Add(new Employee() { Eid = 3, Name = "Kelly", YearsOfExp = 8, Grade = 'A' });
            employees.Add(new Employee() { Eid = 4, Name = "Alex", YearsOfExp = 1, Grade = 'C' });
            employees.Add(new Employee() { Eid = 5, Name = "Peter", YearsOfExp = 5, Grade = 'B' });

            Console.WriteLine("List of employees: ");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}, {employee.YearsOfExp}, {employee.Grade}");
            }
            Console.WriteLine("Employees that can be promoted by grade");
            PromoteEmployee(employees, PromotablebyGrade);
            IsPromotable promotable = new IsPromotable(PromotablebyExp);
            Console.WriteLine("Employees that can be promoted by experience");
            PromoteEmployee(employees, promotable);

        }
        static void PromoteEmployee(List<Employee> employees, IsPromotable isPromotable)
        {
            foreach(var employee in employees)
            {
                if(isPromotable(employee))

                {
                    Console.WriteLine(employee.Name + " can be promoted");
                }
            }
        }
        static bool PromotablebyGrade(Employee employee)
        {
            if (employee.Grade=='A')
                return true;
            return false;
        }
        static bool PromotablebyExp(Employee employee)
        {
            if(employee.YearsOfExp>=5) return true;
            return false;
        }
    }
}
