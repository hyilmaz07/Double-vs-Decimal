
Console.WriteLine("Double vs Decimal");

Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Using Double");

double a = 0.1;
double b = 0.2;


if (a > b)
    Console.WriteLine($"a: ({a}) bigger than b: ({b})");
else
    Console.WriteLine($"b: ({b}) bigger than a: ({a})");

Console.WriteLine("");

if (a + b == 0.3)
    Console.WriteLine($"{a} + {b} equals 0.3");
else
    Console.WriteLine($"{a} + {b} not equals 0.3");

Console.WriteLine("");

Console.WriteLine((a + b) * 30);

Console.WriteLine("");
Console.WriteLine("=================================");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Using Decimal");

decimal c = 0.1m;
decimal d = 0.2m;


if (c > d)
    Console.WriteLine($"a: ({c}) bigger than b: ({d})");
else
    Console.WriteLine($"b: ({d}) bigger than a: ({c})");


if (c + d == 0.3m)
    Console.WriteLine($"{c} + {d} equals 0.3");
else
    Console.WriteLine($"{c} + {d} not equals 0.3");


Console.WriteLine("");

Console.WriteLine((c + d) * 30);
Console.ReadKey();