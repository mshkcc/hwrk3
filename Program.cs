int n;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out n);

for (int i = 1; i <= n; i++)
    Console.Write($"{i * i * i} ");