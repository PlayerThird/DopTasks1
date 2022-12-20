//Проверяем логин (только буквы, 5 символов) и пароль (только цифры, 6 цифр)
int Pas1 = 0;
Console.WriteLine("Введите логин(5 символов)");
string Log = Console.ReadLine();

foreach (var latter in Log)
{
    if (Char.IsDigit(latter) == true) //Проверка, true это наличие цифры
    {
        Console.WriteLine("Воу, воу, тут цифра");
        return;
    }
}
if (Log.Length > 0 && Log.Length < 6)
{
    Console.WriteLine("Всё норм");
}
else{
    Console.WriteLine("Эй-эй, тут логин не более 5 символов, гадай еще");
    return;
}

Console.WriteLine("Введите пороль(6 цифр)");
string Pas = Console.ReadLine();
Pas1 = int.Parse(Pas);

if (int.TryParse(Pas, out Pas1) || Pas.Length < 7 && Pas.Length > 0)
{
    Console.WriteLine("Всё норм");
}
else{
    Console.WriteLine("Эй-эй, тут пароль более 6 символов, гадай еще");
    return;
}

Console.WriteLine("Ну, здарова мир)");