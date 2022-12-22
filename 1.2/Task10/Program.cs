// Ежедневно количество бактерий увеличивается на р процентов
//Через сколько дней количество бактерий увеличится в n раз (ввод р и n)
void Bacterial(double x, double y, double sum){
    double proc1 = y / 100;
    double itogo = sum*x;
    for (int i = 0; sum < itogo; i++)
        {
            if (i > 100)
            {
                break;
            }
            sum += sum*proc1;
            Console.WriteLine("День {0}: сумма бактерий = {1:f2}", i, sum);
        }
}
Console.Write("Введите кол-во бактерий = ");
double bac = double.Parse(Console.ReadLine());
Console.Write("Введите процент на который увеличивается кол-во бактерий в день = ");
double proc = double.Parse(Console.ReadLine());
Console.Write("Кол-во бактерий увеличивается в n раз? n = ");
double n = double.Parse(Console.ReadLine());
Bacterial(n, proc, bac);
