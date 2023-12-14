using VehicleManager.Domain;
using VehicleManager.Foundation;

while (true)
{
    Console.WriteLine(
        "1 - Get vehicle types\r\n" +
        "2 - Filter vehicle by word\r\n" +
        "3 - Save vehicle types\r\n" + 
        "4 - Reverse string\r\n" +
        "5 - Is string palindrome\r\n" +
        "6 - Get missing elements from array\r\n");
    Console.Write("Input digit: ");

    switch (Console.ReadLine())
    {
        case "1":
            {
                Console.WriteLine(string.Join("\r\n", new TypeService()
                    .GetTypeNamesOfSubclassesOrderedByName(typeof(Vehicle))));

                break;
            }
        case "2":
            {
                Console.Write("Enter search word: ");
                Console.WriteLine(string.Join("\r\n", new TypeService()
                    .GetTypeNamesOfSubclassesBySpecifyingPartOfName(typeof(Vehicle), Console.ReadLine() ?? "")));
                
                break;
            }
        case "3":
            {
                new InstantSaverService<Vehicle>()
                    .WriteToJsonFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Path.GetRandomFileName() + ".json", 
                    new InstantService<Vehicle>().GetInstances());
                break;
            }
        case "4":
            {
                Console.Write("Enter string: ");
                Console.WriteLine(new StringService().ReverseString(Console.ReadLine() ?? ""));

                break;
            }
        case "5":
            {
                Console.Write("Enter string: ");
                Console.WriteLine(new StringService().IsPalindrome(Console.ReadLine() ?? ""));

                break;
            }
        case "6":
            {
                Console.Write("Enter array(example - 1 3 4): ");

                var values = Console.ReadLine()?.Split(" ").ToList();
                if (values == null || 
                    values.Any(value => int.TryParse(value, out int numericValue) == false))
                {
                    continue;
                }
                Console.WriteLine(string.Join(" ", new IntArrayService()
                    .MissingElements(values.Select(int.Parse).ToArray())));

                break;
            }
        default:
          break;
    }
    Console.Write("\r\n");
}
