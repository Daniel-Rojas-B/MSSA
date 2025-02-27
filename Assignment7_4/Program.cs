namespace Assignment7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ---- ");
            ParkingSystem ps = new ParkingSystem(1,1,0);
            Console.WriteLine(ps.AddCar(1));
            Console.WriteLine(ps.AddCar(2));
            Console.WriteLine(ps.AddCar(3));
            Console.WriteLine(ps.AddCar(1));
        }
    }
}
