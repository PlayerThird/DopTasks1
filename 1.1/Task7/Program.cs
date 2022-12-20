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
    case "ф":
    Console.WriteLine("Физика");
    break;
    case "и":
    Console.WriteLine("История");
    break;
    case "г":
    Console.WriteLine("География");
    break;
    case "б":
    Console.WriteLine("Биология");
    break;
    case "м":
    Console.WriteLine("Математика");
    break;
    case "р":
    Console.WriteLine("Русский язык");
    break;
    case "л":
    Console.WriteLine("Литература");
    break;
    case "х":
    Console.WriteLine("Химия");
    break;
    default: Console.WriteLine("Ну, видимо еще не добавили такого элемента");
    break;
}