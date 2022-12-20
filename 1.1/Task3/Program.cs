int c = new Random().Next(-10, 10);
int d = new Random().Next(-10,10);
Console.WriteLine("First " + (c) + " Second " + (d));
if (c % 2 == 0 && d % 2 == 0)
{
    Console.WriteLine("Деление "+(c/d));
}
else if(c % 2 != 0 && d % 2 != 0){
    Console.WriteLine("Сумма "+(c + d));
}
else
{
    Console.WriteLine("Умножение "+(c * d));
}
