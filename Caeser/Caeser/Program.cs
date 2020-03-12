using System;

namespace Caeser
{
    class Program
    {
        static void Main(string[] args)
        {
            int shift;
            char letter;
            string plaintext;
            string ciphertext = "";

            // get the message
            Console.WriteLine("Enter your message to be encrypted: ");
            plaintext = Console.ReadLine();

            Console.Write("Enter the shift value (key): ");
            shift = IntCheck();

            // encrypt it
            // first loop for character
            for (int i = 0; i < plaintext.Length; i++)
            {
                letter = plaintext[i];

                if ((!char.IsWhiteSpace(letter)) && char.IsLetter(letter)) // check for letter excluding whitespace
                {
                    for (int n = 0; n < shift; n++) // inner loop for incrementing the shift
                    {
                        letter++; // increment letter by one,

                        if (Convert.ToInt32(char.ToUpper(letter)) > 90)//doesn't store the result but saves having 2 cases, one for upper and one for lower
                        {
                            letter = Convert.ToChar(Convert.ToInt32(letter) - 26);//loops back if out of letter range.
                        }
                    }
                }
                ciphertext += letter;  //add to output string
            }
            // out Encrypt
            Console.WriteLine("Encryption: " + ciphertext);
        }
        static int IntCheck()
        {
            int shift = 0;
            while (!int.TryParse(Console.ReadLine(), out shift) || (shift < 1 || shift > 25))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("Please Enter a valid shift to search for:");
            }
            Console.WriteLine("Valid input");
            return shift;
        }
    }
}
