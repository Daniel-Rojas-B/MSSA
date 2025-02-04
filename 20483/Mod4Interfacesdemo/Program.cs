namespace Mod4Interfacesdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 200,100,30,1999};
            list.Sort();
            foreach (int i in list)
                Console.WriteLine(i);
            

            List<string>names = new List<string>() { "natahn", "jum", "don"};
            names.Sort();

            foreach (string name in names)
                Console.WriteLine(name);

            List<Student> students = new List<Student>();
            students.Add(new Student() { Id=1, age = 26, GPA=3.0f, Name="Daniel"});
            students.Add(new Student() { Id = 2, age = 27, GPA = 4.0f, Name = "Monica" });
            students.Sort(); // Icomparable method , compareto method and do the sorting. 

            foreach (Student student in students)
                Console.WriteLine(student.Name + " " + student.age);

            Console.WriteLine("GPA sorting");
            students.Sort(new StudentGPAComparer());
            foreach (Student student in students)
                Console.WriteLine(student.Name + " " + student.GPA);
            

            Console.ReadKey();
        }
    }
}
