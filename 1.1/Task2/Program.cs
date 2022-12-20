int first = new Random().Next(10, 30);
int second = new Random().Next(10, 30);
Console.WriteLine($"First " + (first) + " Second " + (second));
if (first > second)
{
    Console.WriteLine(first - second);
}
else if(first < second){
    Console.WriteLine(first + second);
}
else
{
    Console.WriteLine("А числа то равны!");
}