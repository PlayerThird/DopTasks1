    do
 {
    Console.WriteLine("Введите радиус: ");
    float r = float.Parse(Console.ReadLine());
    Console.WriteLine("Радиус равен: " + (3.14*r*r));
    Console.WriteLine("Введите Z для выхода если нет, то любой другой символ: ");
 } while (Console.ReadKey(true).Key != ConsoleKey.Z);
