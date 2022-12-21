//Использование цикла while. 
// За один день уровень радиации уменьшается на 5%.
// За сколько дней он кменьгится вдвое?
Console.Write("Введите начальный уровень радиации(100 - 800 единиц): ");
double rad0 = double.Parse(Console.ReadLine());
double rad = rad0;//задание начальных значений rad и day перед тулом цикла
int day = 0;
while (rad > rad0/2)
{
    rad *=0.95;// 5%
    day++;
    Console.WriteLine("День {0}, радиации = {1}", day, rad);
}
Console.ReadKey();