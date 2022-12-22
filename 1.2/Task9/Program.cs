// Генерируется случайные числа в интервале (0, 20) до тех пор,
//пока их сумма не привысит S (вводится с клавиатуры)
//Нумеруются и выводятся эти числа и их сумма
void RandomSum(int y){
    
    int sum = 0;
    for (int i = 0; sum < y; i++)
        {
            int ran = new Random().Next(0,20);
            sum += ran;
            Console.WriteLine("{0}: Число = {1} сумма на данный момент = {2}", i, ran, sum);
        }
}
Console.WriteLine("Введите сумму рандомных чисел");
int x = int.Parse(Console.ReadLine());
RandomSum(x);