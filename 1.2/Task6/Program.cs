//Генерируется 8 случайных чисел в интервале (-30, 30)
//Выводятся эти числа и сообщения: отрицательное - положительное, четное-нечет
// internal partial class Program
// {
//     private static void Main(string[] args)
//     {
//         GeneratorNumber(8);
//         Pechat(array);
// }
//     static Array GeneratorNumber(){
//         int[] array = new int[arrayLenght];
//         for (int i = 0; i < array.Lenght; i++)
//         {
//             array[i] = new Random.Next(-30, 30);
//         }
//     }
//     static void Pechat(array){
//         for (int i = 0; i < array.Lenght; i++)
//         {
//             Console.WriteLine(array(i));
//         }
//     }
// }
int[] array = new int[8];
        for (int i = 0; i < 8; i++)
         {
            array[i] = new Random().Next(-30, 30);
            Console.Write(array[i]);
            if (array[i] > 0)
            {
                Console.Write(" положительное ");
            }
            else
            {
                Console.Write(" отрицательное ");
            }
            if (array[i]%2 != 0)
            {
                Console.WriteLine(" нечетное ");
            }
            else
            {
                Console.WriteLine(" чётное ");
            }
         }