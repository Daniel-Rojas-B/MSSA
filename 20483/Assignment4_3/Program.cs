namespace Assignment4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ---- ");
            Console.WriteLine("Enter customer id: ");
            int customerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the customer name: ");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter unit consumed: ");
            int unitsConsumed = int.Parse(Console.ReadLine());

            Console.WriteLine($"Customer IDNO: {customerId}");
            Console.WriteLine($"Customer name: {customerName}");
            Console.WriteLine($"Units consumed: {unitsConsumed}");
            CalculateCharges(unitsConsumed);

            Console.WriteLine(" ---- Problem 2 ---- ");
            Console.WriteLine("Input the number of elements to be stored in the array: ");
            int numberElements = int.Parse(Console.ReadLine());
            int[] elementsArray = new int[numberElements];
            Console.WriteLine($"Input {numberElements} elements in the array: ");
            for (int i = 0; i < numberElements; i++)
            {
                Console.Write($"Element - {i}: ");
                elementsArray[i] = int.Parse(Console.ReadLine());
            }
            Frecuency(elementsArray);

            Console.WriteLine(" ---- Problem 3 ---- ");
            Console.Write("Input the number of elements to be stored in the array: ");
            int numberElements1 = int.Parse(Console.ReadLine());
            int[] elementsArray1 = new int[numberElements1];
            Console.WriteLine($"Input {numberElements1} elements in the array: ");
            for (int i = 0; i < numberElements1; i++)
            {
                Console.Write($"Element - {i}: ");
                elementsArray1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The unique elements found in the array are: ");
            UniqueElements(elementsArray1);

            Console.ReadKey();
        }
        public static void CalculateCharges(int unitsConsumed)
        {
            if (unitsConsumed <= 199 && unitsConsumed*1.2<400)
            {
                
                Console.WriteLine($"Amount charges @$1.20 per unit: {unitsConsumed * 1.20}");
                Console.WriteLine($"Surcharge amount: 0");
                Console.WriteLine($"Net amount paid by the customer: {unitsConsumed * 1.20}");
            }
            else if (unitsConsumed < 400 && unitsConsumed * 1.5 < 400)
            {

                Console.WriteLine($"Amount charges @$1.50 per unit: {unitsConsumed * 1.50}");
                Console.WriteLine($"Surcharge amount: 0");
                Console.WriteLine($"Net amount paid by the customer: {unitsConsumed * 1.50}");
            }
            else if (unitsConsumed < 400 && unitsConsumed * 1.5 >= 400)
            {

                Console.WriteLine($"Amount charges @$1.50 per unit: {unitsConsumed * 1.50}");
                Console.WriteLine($"Surcharge amount: {unitsConsumed * 1.5*0.15}");
                Console.WriteLine($"Net amount paid by the customer: {unitsConsumed * 1.50 + unitsConsumed * 1.5 * 0.15}");
            }
            else if (unitsConsumed < 600 )
            {

                Console.WriteLine($"Amount charges @$1.80 per unit: {unitsConsumed * 1.80}");
                Console.WriteLine($"Surcharge amount: {unitsConsumed * 1.5 * 0.15}");
                Console.WriteLine($"Net amount paid by the customer: {unitsConsumed * 1.80 + unitsConsumed * 1.8 * 0.15}");
            }
            else
            {
                Console.WriteLine($"Amount charges @$2.00 per unit: {unitsConsumed * 2.00}");
                Console.WriteLine($"Surcharge amount: {unitsConsumed * 2 * 0.15}");
                Console.WriteLine($"Net amount paid by the customer: {unitsConsumed * 2 + unitsConsumed * 2 * 0.15}");
            }
        }
        public static void Frecuency(int[] numsArray)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();

            foreach (int number in numsArray)
            {
                if(map.ContainsKey(number))
                {
                    map[number]++;
                }
                else
                {
                    map[number] = 1;
                }
            }
            Console.WriteLine("Frequency of all elements of array: ");
            foreach (var key in map.Keys)
            {
                Console.WriteLine($"{key} occurs {map[key]} times");
            }
        }
        public static void UniqueElements(int[] numsArray)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (int number in numsArray)
            {
                if (map.ContainsKey(number))
                {
                    map[number]++;
                }
                else
                {
                    map[number] = 1;
                }
            }
            foreach (var key in map.Keys)
            {
                if (map[key] == 1)
                {
                    Console.Write(key + " ");
                }
            }
        }
    }
}
