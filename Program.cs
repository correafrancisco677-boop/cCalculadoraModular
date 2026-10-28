Console.WriteLine("=== CALCULADORA MODULAR ===");
Console.Write("Primer número: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal a)) { Console.WriteLine("Número inválido."); return; }
Console.Write("Segundo número: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal b)) { Console.WriteLine("Número inválido."); return; }
Console.WriteLine($"Suma: {Sumar(a, b)}");
Console.WriteLine($"Resta: {Restar(a, b)}");
Console.WriteLine($"Multiplicación: {Multiplicar(a, b)}");
Console.WriteLine(b == 0 ? "No se puede dividir entre cero." : $"División: {Dividir(a, b)}");

decimal Sumar(decimal x, decimal y) => x + y;
decimal Restar(decimal x, decimal y) => x - y;
decimal Multiplicar(decimal x, decimal y) => x * y;
decimal Dividir(decimal x, decimal y) => x / y;
