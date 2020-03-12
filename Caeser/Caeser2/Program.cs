using System;

namespace Caeser
{
    class Program
    {
        static void Main(string[] args)
        {
            int shift;
            char letter;
            string plaintext = "";
            string ciphertext = "";
            int codeType;

            do
            {
                Console.WriteLine("Enter 1 for encrypt, 2 for decrypt or 3 for quit");
                codeType = IntCheck();

                if (codeType == 1)
                {
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
                else if (codeType == 2)
                {
                    // get the message
                    Console.WriteLine("Enter your message to be decrypted: ");
                    ciphertext = Console.ReadLine();

                    Console.Write("Enter the decryption key (26-original key) : ");
                    shift = IntCheck();

                    // decrypt it
                    // first loop for character
                    for (int i = 0; i < ciphertext.Length; i++)
                    {
                        letter = ciphertext[i];

                        if ((!char.IsWhiteSpace(letter)) && char.IsLetter(letter)) // check for letter excluding whitespace
                        {
                            for (int n = 0; n < shift; n++) // inner loop for incrementing the shift
                            {
                                letter--; // decrement letter by one,

                                if (Convert.ToInt32(char.ToLower(letter)) < 97)//doesn't store the result but saves having 2 cases, one for upper and one for lower
                                {
                                    letter = Convert.ToChar(Convert.ToInt32(letter) + 26);//loops back if out of letter range.
                                }
                            }
                        }
                        plaintext += letter;  //add to output string
                    }
                    // out Encrypt
                    Console.WriteLine("Decryption: " + plaintext);
                }
            } while (codeType != 3);

            
        }
        static int IntCheck()
        {
            int number = 0;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("Please Enter a valid integer:");
            }
            Console.WriteLine("Valid input");
            return number;
        }
    }
}
