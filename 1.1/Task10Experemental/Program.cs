string word = "Длинное44слово";
Console.WriteLine(Char.IsDigit(word));
foreach (var latter in word)
{
    Console.WriteLine(Char.IsDigit(latter));
    if (Char.IsDigit(latter) == true)
    {
        Console.WriteLine("Воу, воу, тут цифра");
        return;
    }
}