/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

int number;
Console.Write("Введите число от 1 до 7: ");
int.TryParse(Console.ReadLine()!, out number);
if (number > 7 || number < 1)
{
    Console.Write("Вы ввели неверное число ");
}

else if (number == 1)
{
    Console.Write("Нет, понедельник рабочий день ");
}
else if (number == 2)
{
    Console.Write("Нет, вторник рабочий день ");
}
else if (number == 3)
{
    Console.Write("Нет, среда рабочий день ");
}
else if (number == 4)
{
    Console.Write("Нет, четверг рабочий день ");
}
else if (number == 5)
{
    Console.Write("Нет, пятница рабочий день ");
}
else if (number == 6)
{
    Console.Write("Да, суббота выходной день ");
}
else if (number == 7)
{
    Console.Write("Да, воскресенье выходной день ");
}
