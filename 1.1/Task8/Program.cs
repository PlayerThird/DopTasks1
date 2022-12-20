Console.WriteLine("Введите букву предмета");
string buk = Console.ReadLine();
int lem = buk.Length;
if (lem > 1)
{
    Console.WriteLine("Буква = 1 буква, давай еще раз");
    return;
}
switch (buk)
{
    case "б":
    Console.WriteLine("Белорусь, Минск");
    break;
    case "р":
    Console.WriteLine("Россия, МКАД");
    break;
    case "л":
    Console.WriteLine("Литва, Вильнос");
    break;
    default: Console.WriteLine("Ну, видимо еще не добавили такого города или он горит в ядерном пепле --_--");
    break;
}