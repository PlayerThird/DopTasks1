Console.WriteLine("Введите первую цифру: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую цифру: ");
int n2 = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = n1; i < n2+1; i++){
    if (i%2 != 0)
    {
        sum += i;
    }
    Console.Write("I = "+ i);
    Console.WriteLine("Sum= " + sum);
}
Console.WriteLine(sum);