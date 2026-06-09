Random random = new Random();

for (int i = 1; i <= 5; i++)
{
    int a = random.Next(1, 100);
    int b = random.Next(1, 100);
    
    Console.WriteLine($"Equation {i}:");
    Console.WriteLine($"  Addition: {a} + {b} = {a + b}");
    Console.WriteLine($"  Subtraction: {a} - {b} = {a - b}");
    Console.WriteLine();
}
