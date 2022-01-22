// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0.
Console.Write("Введите х: ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine() ?? "0");
if((x > 0) && (y > 0))
{
    Console.WriteLine("Первая четверть");
}
if((x > 0) && (y <0))
{
    Console.WriteLine("Четвёртая четверть");
}
if((x < 0) && (y > 0))
{
    Console.WriteLine("Вторая четверть");
}
if((x < 0) && (y < 0))
{
    Console.WriteLine("Третья четверть");
}