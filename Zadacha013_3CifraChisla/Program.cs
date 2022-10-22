// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число(если после запятой в дробном числе последней цифрой указан 0, он не будет учтен): ");
double number = Convert.ToDouble(Console.ReadLine());
int resault = Convert.ToInt32(number);

// Проверка числа на отрицательность
if (number < 0)
{
    number = number * (-1);
}
// Нахождение 3 цифры целых чисел 
if (number >= 100)
{
    while (number >= 1000)
    {
        number = number / 10;
    }

    resault = (int)number % 10;
    Console.WriteLine($"Третья цифра данного числа: {resault}");
}

else
{
    // Нахождение третьей цифры для дробных чисел
    // Определение является ли число дробным 
    if (number * 10 != (int)number * 10 && number != 0)
    {
        if (number >= 10)
        {
            resault = (System.Convert.ToInt32(number * 10)) % 10;
            Console.WriteLine($"Третья цифра данного числа: {resault}");            
        }
        else
        // Определение наличия цифр после первой цифры в дробной части числа меньше 10
        if (number * 10 != (int)(number * 10))
        {
            resault = (System.Convert.ToInt32(number * 100)) % 10;
            Console.WriteLine($"Третья цифра данного числа: {resault}");
        }
        else
        {
             Console.WriteLine("У данного числа третьей цифры нет");
        }
    }
    else
    {
        Console.WriteLine("У данного числа третьей цифры нет");
    }
}
Console.ReadKey();