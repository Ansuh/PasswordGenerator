using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PasswordGenerators

{
    private const string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string smallLetters = "abcdefghijklmnopqrstuvwxyz";
    private const string digits = "0123456789";
    private const string specChar = "!@#$%^&*~`?/";
    private const string allChars = capitalLetters + smallLetters + specChar;
    private static Random rnd = new Random();


    static void Main()
    {
        StringBuilder password = new StringBuilder();

        for (int i = 1; i <= 2; i++)
        {
            char capitalLetter = GenerateChar(capitalLetters);
            InsertAtRandomPositions(password, capitalLetter);
        }
        for (int i = 1; i <= 2; i++)
        {
            char smallLetter = GenerateChar(smallLetters);
            InsertAtRandomPositions(password, smallLetter);
        }
        for (int i = 1; i <= 2; i++)
        {
            char capitalLetter = GenerateChar(capitalLetters);
            InsertAtRandomPositions(password, capitalLetter);
        }

        char digit = GenerateChar(digits);
        InsertAtRandomPositions(password, digit);

        for (int i = 1; i <= 3; i++)
        {
            char chars = GenerateChar(specChar);
            InsertAtRandomPositions(password, chars);
        }

        int count = rnd.Next(8);

        for (int i = 0; i <= count; i++)
        {
            char specChar = GenerateChar(allChars);
            InsertAtRandomPositions(password, specChar);
        }

        Console.WriteLine("Your new password is:");
        Console.WriteLine(password);
        Console.WriteLine("Your password consists of {0} elements", password.Length);
        Console.ReadLine();
        Console.ReadKey();
    }

        

    private static void InsertAtRandomPositions(StringBuilder password, char character)
    {
        int randomPosition = rnd.Next(password.Length+1);
        password.Insert(randomPosition, character);
    }
    private static char GenerateChar(string availableChars)
    {
        int randomIndex = rnd.Next(availableChars.Length);
        char randomChar = availableChars[randomIndex];
        return randomChar;
    }
}



    



    




