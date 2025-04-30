

using System.Diagnostics.Metrics;

string FirstName = Console.ReadLine();
string LastName = Console.ReadLine();
string Country = Console.ReadLine();

if (
Country.Equals("United States", StringComparison.OrdinalIgnoreCase) ||
Country.Equals("USA", StringComparison.OrdinalIgnoreCase) ||
Country.Equals("US", StringComparison.OrdinalIgnoreCase) ||
Country.Equals("U.S.A", StringComparison.OrdinalIgnoreCase) ||
Country.Equals("United States of America", StringComparison.OrdinalIgnoreCase)
)
{
    Console.WriteLine($"Hello fellow American {FirstName} {LastName}");
}
else
{
    Console.WriteLine($"Hello, {FirstName} {LastName} from {Country}");
}

