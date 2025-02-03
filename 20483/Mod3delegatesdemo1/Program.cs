namespace Mod3delegatesdemo1
{
    internal class Program
    {
        // applications:
        // 1. in event driven prog , even handlers and related to the events via the delegates
        // 2. anonymous methods / lamba expressions
        // 3. LING: language integrated queries
        // 4. passing logic to another method

        delegate void Greet(string name);
        delegate int PerformCalculation(int x, int y);
        static void Main(string[] args)
        {
            //direct funtion call
            SayHello("Amy");
            Greet mygreeting = new Greet(SayHi);
            mygreeting += SayHello;
            mygreeting("Daniel"); // delegate

            mygreeting -= SayHello;
            // mygreeting += add;
            mygreeting("Felipe");

            DisplayGreetings(SayHello, "Daniel");
            DisplayGreetings(SayHi, "Felipe");

            Console.WriteLine(Calculate(Add, 34, 33));

            Console.ReadKey();
        }
        static void DisplayGreetings(Greet greeting, string name)
        {
            greeting(name);
        }
        static int add(int num1, int num2)
        {
            return num1 + num2; 
        }
        static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }
        static int Calculate(PerformCalculation perform, int x , int y)
        {
            return perform(x,y); //  via the delegate , we are calling the method
        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
