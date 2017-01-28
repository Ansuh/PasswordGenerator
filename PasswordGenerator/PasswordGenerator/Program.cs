using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        private const string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string smallLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string digits = "0123456789";
        private const string specChar = "!@#$%^&*~`?/";
        private const string allChars = capitalLetters + smallLetters + specChar;
        private static Random rnd = new Random();
        

        static void Main(string[] args)
        {
            StringBuilder password = new StringBuilder();

            for (int i = 1; i <= 2; i++)
            {
                char capitalLetter = GenerateChar(capitalLetters);
                insertAtRandomPositions(password, capitalLetter);
            }
            for (int i = 1; i <= 2; i++)
            {
                char smallLetter = GenerateChar(smallLetters);
                insertAtRandomPositions(password, smallLetter);
            }
            for (int i = 1; i <= 2; i++)
            {
                char capitalLetter = GenerateChar(capitalLetters);
                insertAtRandomPositions(password, capitalLetter);
            }



        }
    }
}
