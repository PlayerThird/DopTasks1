int n = new Random().Next(20, 90);
Console.WriteLine(n);
Console.WriteLine("Введите делимое число");
int x = Convert.ToInt32(Console.ReadLine());
if (n%x ==0){
 Console.WriteLine("Да, оно делится");}
 else
 {
    Console.WriteLine("Nope, оно не делится");
 }

