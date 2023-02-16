/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int num = new Random().Next();
if (num > 999)
{
    string ansStr = (num /= 10).ToString();
    string ansStr2 = (num % 10).ToString(); 
    Console.Write($"{num} -> {ansStr2}");
}
else if (num < 100)
{
    Console.Write($"{num} -> Третей цыфры нет ");
}