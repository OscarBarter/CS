using System;
using System.Collections.Generic;
using System.Text;

namespace BaseToBase
{
    class BaseConversions
    {
        public static string DecimalToBase(int Base, string DecimalStr)
        {
            //Console.WriteLine("Enter the decimal integer to be converted: ");
            //int Decimal = Convert.ToInt32(Console.ReadLine());
            int Decimal = Int32.Parse(DecimalStr);
            int bit;
            string result = "";
            while (Decimal > 0)
            {
                bit = Decimal % Base;
                result = bit.ToString() + result;
                Decimal = Decimal / Base;
            }
            return result;
        }

        public static int BinaryToDecimal(string binary)
        {
            //Console.WriteLine("Enter the binary integer to be converted: ");
            //string binary = (Console.ReadLine());
            int result = 0;
            int power = 1;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    result = result + power;
                }
                power = power * 2;
            }
            return result;
        }

        public static string TwosBinToDec(string TwosBinary)
        {
            //bool qOne = false;
            double total = 0;
            char firstChar = TwosBinary[0];
            if (firstChar == '1')
            {
                int length = TwosBinary.Length;
                total = 0 - Math.Pow(2, length -1);
            }

            string BinaryStr = TwosBinary;
            /*char[] BinaryArray = BinaryStr.ToCharArray();
            BinaryArray[0] = '0';
            BinaryStr = BinaryArray.ToString();*/
            BinaryStr = '0' + BinaryStr.Substring(1);
            int Binary = BinaryToDecimal(BinaryStr);
            total += Binary;
            
            return total.ToString();
        }

        public static string DecimalTo2sBin(int Decimal)
        {
            if (Decimal > -1)
            {
                string DecString = Decimal.ToString();
                string output = DecimalToBase(2, DecString);
                while (output.Length < 16)
                {
                    char letter = '0';
                    output = letter + output;
                }
                if (output.Length > 16)
                {
                    output = "Overflow";
                }
                return output;
            }
            else
            {
                Decimal = Decimal + -2*Decimal;
                string DecString = Decimal.ToString();
                string PosBinary = DecimalToBase(2, DecString);

                bool qOne = false;
                string output = "";

                for (int i = PosBinary.Length - 1; i > 0; i--)
                {
                    if (qOne == false)
                    {
                        if (PosBinary[i] == '1')
                        {
                            qOne = true;
                        }
                        char letter = PosBinary[i];
                        output = letter + output;
                    }
                    else
                    {
                        char letter;
                        if (PosBinary[i] == '1')
                        {
                            letter = '0';
                        }
                        else
                        {
                            letter = '1';
                        }
                        output = letter + output;
                    }
                }
                while (output.Length < 16)
                {
                    char letter = '1';
                    output = letter + output;
                }
                if (output.Length > 16)
                {
                    output = "Not valid";
                }
                return output;
            }
        }
    }
}
