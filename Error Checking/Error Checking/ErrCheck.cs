using system;
   
    
namespace Error_Checking_functions
{
    class Check_Digit
    {
        public static void Check_digit()
        {
            Console.Write("Enter the product code--> ");
            string digits = Console.ReadLine();

            string output;
            int digit;

            digit = Checksum_ISBN13(digits);
            if (digit == -1)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                output = digit.ToString() + digits;
                Console.WriteLine("The check digit is: {0}", digit);
                Console.WriteLine("The full product code is: {0}", output);
            }
        }


        static int Checksum_ISBN13(string data)
        {
            // Test string for correct length
            if (data.Length != 12 && data.Length != 13)
                return -1;

            // Test string for being numeric
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 0x30 || data[i] > 0x39)
                    return -1;
            }

            int sum = 0;

            for (int i = 11; i >= 0; i--)
            {
                int digit = data[i] - 0x30;
                if ((i & 0x01) == 1)
                    sum += digit;
                else
                    sum += digit * 3;
            }
            int mod = sum % 10;
            return mod == 0 ? 0 : 10 - mod;
        }
    }

    class parity
    {
        public static void Parity()
        {
            Console.Write("Enter the character to be encoded --> ");
            char character = Char.Parse(Console.ReadLine());

            int ASCIICode = Convert.ToInt32(character);
            Console.WriteLine("The ASCII Code is: {0}", ASCIICode);

            string binary = Other.DecimalToBinary(ASCIICode);
            Console.WriteLine("The binary of this is: {0}", binary);

            Console.Write("Would you like to use o/e parity? -->");
            string qParity = Console.ReadLine();


            int parityBit;

            if (qParity == "e")
            {
                Console.WriteLine("Even Parity being used");
                parityBit = ParityBit(int.Parse(binary), 'e');
            }
            else
            {
                Console.WriteLine("Odd Parity being used");
                parityBit = ParityBit(int.Parse(binary), 'o');
            }

            Console.WriteLine("The parity bit is: {0}", parityBit);

            string output = parityBit.ToString() + binary;
            Console.WriteLine("The full code is: {0}", output);

        }

        static int ParityBit(int binary, char parity)
        {
            string binstring = binary.ToString();

            int counter1s = 0;

            foreach (char bit in binstring)
            {
                if (bit == '1') { counter1s++; }
            }

            if (parity == 'e')
            {
                if (counter1s % 2 == 1) { return 1; }
                else { return 0; }
            }
            else
            {
                if (counter1s % 2 == 1) { return 0; }
                else { return 1; }
            }
        }
    }

    class Majority_Voting
    {
        public static void MajorityVoting()
        {
            Console.Write("Enter the character to be encoded --> ");
            char character = Convert.ToChar(Console.ReadLine());

            int ASCIICode = Convert.ToInt32(character);
            Console.WriteLine("The ASCII Code is: {0}", ASCIICode);

            string binary = Other.DecimalToBinary(ASCIICode);
            Console.WriteLine("The binary of this is: {0}", binary);

            Console.Write("Enter the number of times you would like to repeat the digits --> ");
            int repeat = int.Parse(Console.ReadLine());


            string binExtend = "";
            for (int bitNo = 0; bitNo < binary.Length; bitN){

            }

                }
    }
}
