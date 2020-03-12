using System;
using System.Collections.Generic;
using System.Text;

namespace File_Encryption
{
    class Encrypt_Decrypt
    {
        public static string EncryptCC(string plaintext, int shift)
        {
            char letter;
            string ciphertext = "";
            //encrypt it
            //outer loop: step through the plaintext, one character at a time
            plaintext = plaintext.ToUpper(); //working in upper case
            for (int i = 0; i < plaintext.Length; i++)
            {
                letter = plaintext[i];
                for (int n = 0; n < shift; n++)
                {
                    if (letter == 'Z')
                    {
                        letter = 'A'; //loop back to beginning of alphabet
                    }
                    else
                    {
                        letter++;
                    }
                }
                ciphertext += letter;
            }
            return ciphertext;
        }


        public static string DecryptCC(string ciphertext, int shift)
        {
            char letter;
            string plaintext = "";
            //encrypt it
            //outer loop: step through the plaintext, one character at a time
            ciphertext = ciphertext.ToUpper(); //working in upper case
            for (int i = 0; i < ciphertext.Length; i++)
            {
                letter = ciphertext[i];
                for (int n = 0; n < shift; n++)
                {
                    if (letter == 'A')
                    {
                        letter = 'Z'; //loop back to beginning of alphabet
                    }
                    else
                    {
                        letter--;
                    }
                }
                plaintext += letter;
            }
            return plaintext;
        }
    }
}
