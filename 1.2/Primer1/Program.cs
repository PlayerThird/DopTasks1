//Использование цикла for для вычисления суммы и произведения n натуральных чисел
Console.WriteLine("Введите целое число (от 3 до 9)");
int n = int.Parse(Console.ReadLine());// Ввод строки, преобразование в int
int sum = 0;//Задание начальных значений sum и pro перед цикла
int pro = 1;
for (int i = 1; i < n; i++)
{
    sum += i;
    pro *= i;
    //тело цикла: вычисления и вывод
    Console.WriteLine("Шаг = {0} сумма = {1} произведение {2}", i, sum, pro);
}
Console.ReadKey();