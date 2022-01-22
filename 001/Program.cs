// Проверить кратно ли число 7 и 23.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else 
{
    Console.WriteLine("Число не кратно 7 и 23");
}

// || - логическое "ИЛИ"
// && - логическое "И"
// ! - логическое "НЕ"