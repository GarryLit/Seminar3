/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
string UserNumberStr;
Console.WriteLine("Ведите пятизначное число");
    UserNumberStr = Console.ReadLine();

 
if (UserNumberStr.Length == 5)
    PalindromeDefinition (UserNumberStr);
else                
    Console.WriteLine("Число не пятизначное ");


void PalindromeDefinition (string str) 
{
if (str[0] == str[4] && str[1] == str[3])
    Console.WriteLine("Ваше число палиндром");
else
    Console.WriteLine("Ваше число не палиндром");
}







