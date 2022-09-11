// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да 
int DataInput(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int InputChislo()
{
    int chislo = DataInput("Enter a five-digit number:");
    return chislo;
}

bool CheakPalindrom (int chislo)
{
    int bufer = chislo;
    if (chislo < 0)
    {
        bufer = - chislo;
    }
    if(bufer < 10)
    
    
    {
        Console.WriteLine("A number consisting of one digit cannot be a palindrome");
        return false;
    }
    return true;
}

int ReverseNumber(int chislo)
{
    if (chislo < 0)
    {
        chislo *= -1;
    }

    int reverse = 0;
    while (chislo > 0)
    {
        reverse = reverse * 10 + chislo % 10;
        chislo = chislo / 10;
    }

    return reverse;
}

Console.WriteLine("The program takes a number as input and checks whether it is a palindrome");

int chislo = InputChislo();
if (CheakPalindrom(chislo))
{
    int reverse = ReverseNumber (chislo);
    System.Console.WriteLine($"Expanded the entered number: ");

    if (ReverseNumber(chislo) == chislo)
    {
        Console.WriteLine($"{chislo}-> да");
    }
    else
    {
        Console.WriteLine($"{chislo} ->нет");
    }
}