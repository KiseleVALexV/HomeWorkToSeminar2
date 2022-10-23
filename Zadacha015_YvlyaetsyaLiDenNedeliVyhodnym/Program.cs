// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int number;
Console.WriteLine("Введите число, обозначающее день недели(от 1 до 7) : ");
string EntSign = Console.ReadLine();

while (!Int32.TryParse(EntSign, out number) || number < 1 || number > 7)
{
    Console.WriteLine($"Неправильный ввод. Введите число, обозначающее день недели(от 1 до 7) : ");
    EntSign = Console.ReadLine();
}

if (number == 6 || number == 7)
{
    Console.WriteLine($"День {number} - выходной");
}
else
{
    Console.WriteLine($"День {number} - не выходной");
}
Console.ReadKey();