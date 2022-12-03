//Задача 19
//Напишите программу, которая принимает
//на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

using static System.Console;
Clear();

WriteLine("Введите число из 5 или более цифр");
int number = Convert.ToInt32(ReadLine()!);
bool Palindrome(int num)
{
    string reverse = number.ToString();
    for (int i = 0; i < reverse.Length / 2; i++) 
        if (reverse[i] != reverse[reverse.Length - 1 - i])                        
            return false;
    return true;
}
if (Palindrome(number) == true)
    WriteLine("Палиндром!");
else
    WriteLine("Не палиндром!");