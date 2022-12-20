Console.WriteLine("Введите ваш рост в см ");
int rost = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваш вес ");
int ves = Convert.ToInt32(Console.ReadLine());
if (rost < 0 || ves < 0)
{
    Console.WriteLine("Неожидал? Новый сникерс с миндалём, держи конфетку и пробуй еще раз :)");
    return;
}
else if(rost > 250){
    Console.WriteLine("Я вызываю МЧС, стой на месте!");
    return;
}
else if(ves > 200){
    Console.WriteLine("Без разговоров, я вызываю эвакуатор --_--");
}
else if(rost <= 100)
int ideal1 = (rost - 100); ideal1 = ideal1 + ideal1/10;// Идеал + 10%
Console.WriteLine("Идеальный вес 1 = " + (ideal1));
int ideal2 = (rost - 100); ideal2 = ideal2 - ideal2/10;// Идеал - 10%
Console.WriteLine(("Идеальный вес 1 = " +ideal2));
if (ves >= ideal2 && ves <= ideal1)
{
    Console.WriteLine("У вас идеальный вес");
}
else if(ves < ideal2){
    Console.WriteLine("А ну булки в руки и больше есть!");
}
else if(ves > ideal1){
    Console.WriteLine("Вставай с дивана и иди в фитнес. Ближайший к вам: ДВЕРЬ НА УЛИЦУ!");
}