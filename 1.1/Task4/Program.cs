Console.WriteLine("Введите номер месяца");
int mes = Convert.ToInt32(Console.ReadLine());
if (mes > 12 || mes < 1)
{
    Console.WriteLine("Неа, дружище, давай еще раз");
    return;
}
if (mes <= 2 || mes == 12)
{
    Console.WriteLine("Ну да, зимой у нас сессия");
}
else if(mes <= 5)
{
    Console.WriteLine("Ну да, каникулы весной, а что такого?");
}
else if(mes <= 8)
{
    Console.WriteLine("Ну да, летом начинается 1 семестр");
}
else if(mes <= 11)
{
    Console.WriteLine("Ну да, страдай дальше в 2м семестре");
}