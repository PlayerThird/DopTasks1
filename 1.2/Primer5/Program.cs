// Реализация многократного ввода: цикл do..while
double n =0, sum = 0;//обьявляем и инициализируем переменные
string s = "";
do
{
    Console.Write("Введите число: ");
    s = Console.ReadLine();//ввод
    if (double.TryParse(s, out n))//преобразование в double
    {
        sum += n;//Суммирование чисел
        Console.WriteLine("Сумма = " + sum);
    }//повторяем ввод до тех пор, пока не введен символ "Q"
} while (s!="Q");//выход из цикла по условию