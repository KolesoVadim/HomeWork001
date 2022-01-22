// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
if(number > 5)
{
    Console.WriteLine("Это выходной день.");
}
else
{
    Console.WriteLine("Это будний день.");
}
if(number >= 8)
{
    Console.WriteLine("Вы ввели некоректный день недели.");
}