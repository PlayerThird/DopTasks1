Console.WriteLine("Введите число от 0 до 5");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0 || num > 5){
    Console.WriteLine("Я тебе что сказал!? >:(");
    return;
}
switch (num)
{
    case 0:
    Console.WriteLine("Zero");
    break;
    case 1:
    Console.WriteLine("One");
    break;
    case 2:
    Console.WriteLine("Second");
    break;
    case 3:
    Console.WriteLine("Third");
    break;
    case 4:
    Console.WriteLine("Four");
    break;
    case 5:
    Console.WriteLine("Five");
    break;
}