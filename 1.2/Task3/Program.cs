// Вычисляется и выводится в таблицу с шагом 10км стоимость поездки
//на автомобиле в зависимости от растояни S(10-90км).
//С клавиатуры вводятся: b - расход бензина на 100км
//с - цена бензина за 1 литр
Console.WriteLine("Ведите растояние: ");
int S = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите расход бензина: ");
float ras = float.Parse(Console.ReadLine());
Console.WriteLine("Введите цену на ваш бензин: ");
float k = float.Parse(Console.ReadLine());
float itogo = 0;
for (int i = 10; i < S+10; i+=10)
{
    Console.WriteLine("Расстояние = " + i);
    itogo += ras/10 * k;
    Console.WriteLine("Цена на бенз = " + itogo);
}