using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen
{
    class PassGen
    {
        const string numb = "0123456789";
        const string lettL = "abcdefghijklmnopqrstuvwxyz";
        const string lettU = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


        private char[] pin;
        private string letters = String.Empty;
        private string[] lettersarray = { numb, lettL, lettU };

        public PassGen(int length, params int[] condition)
        {
            if (length >= 8)
            {
                pin = new char[length];
            }
            else
                throw new ArgumentOutOfRangeException("Password can not contain less than 8 members");

        }
    }
}
