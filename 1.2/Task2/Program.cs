// Вычисляется сумма квадратов n натуральных чисел, начиная с k
Console.WriteLine("Введите цифру: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сколько раз нужно найти квадрат: ");
int k = int.Parse(Console.ReadLine());
int sum = n*n;
for (int i = 1; i < k; i++)
{
    sum = sum * n; 
    Console.WriteLine("Шаг = " + i);
    Console.WriteLine("Сумма" + sum);
}
Console.WriteLine(sum);