// Вклады в банках с простыми и сложными процентами(while)
Console.Write("Введите начальный вклад (от 100 до 500 руб): ");
double vklad = double.Parse(Console.ReadLine());// перевод строки в тип double
Console.Write("Введите процентную ставку (от 10 до 30): ");
double proc = double.Parse(Console.ReadLine());
double sum1=vklad, sum2 = vklad;
int god = 0;
while (sum1 < 2*vklad)//условие - удвоение суммы
{
    //выполняем вычисления накопительных сумм и задаем приращение года
    sum1 += proc * vklad / 100;
    sum2 *= (1 + proc / 100);
    god++;
    Console.WriteLine("Год {0}, банк1 = {1}, банк2 = {2}", god, sum1, sum2);
}
Console.ReadKey();