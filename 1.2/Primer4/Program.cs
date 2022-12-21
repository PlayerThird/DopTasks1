//Реализация многократного ввода: бесконечный цикл while
double n=0, sum =0;
string s = "";
while (true)//бесконечный цикл while
{
    Console.Write("Введите число ");
    s = Console.ReadLine();//ввод
    if(s == "Q") break; //Выход из цикла по условию ввода на Q
    if (double.TryParse(s, out n))
    {
        sum += n;
        Console.WriteLine("Сумма = " + sum);
    }
}