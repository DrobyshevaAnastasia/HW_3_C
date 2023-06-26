/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int pal = number.Length;
if (pal == 5)
{
    if (number[0] == number[4] && number [1] == number [3])
    {
        Console.WriteLine("Число" + ", Палиндром!");
    
    }
    else
    {
        Console.WriteLine("Число" + ", НЕ Палиндром");
    }
}

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


int number = ReadInt("Введите число N: ");
for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i*i*i} ");
}
int ReadInt(string mes)
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine());
}
*/