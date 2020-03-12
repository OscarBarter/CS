using System;


namespace EcDc
{
    class CeaserCipher
    {
        public static string EncryptCC(string plaintext, int shift)//encryption for ceaser cipher
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
            //outer loop: step through the ciphertext, one character at a time
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


    class Vigeneere
    {
        public static string EncryptVi(string plaintext, string key)
        {
            char letter;//declare and intitialise variables
            string ciphertext = "";
            int j = 0;
            key = key.ToLower();
            letter = ' ';
            for (int i = 0; i < plaintext.Length; i++, j++)//j is for the key, i is for the plaintext
            {
                if (j == key.Length)
                {
                    j = 0;
                }//loop for checking if the key needs resetting

                char character = plaintext[i];
                char keyLetter = key[j];
                int shift = Convert.ToInt32(keyLetter) - 97;
                letter = Convert.ToChar(CeaserCipher.EncryptCC(character.ToString(), shift));//ceaser cipher the induvidual characters by the shift of one of the key characters

                ciphertext += letter;//add to the ciphertext
            }
            return ciphertext;
        }

        public static string DecryptVi(string ciphertext, string key)
        {
            char letter;
            string plaintext = "";
            int j = 0;
            key = key.ToLower();
            letter = ' ';
            for (int i = 0; i < ciphertext.Length; i++, j++)//i for the ciphertext and j for the key
            {
                if (j == key.Length)
                {
                    j = 0;
                }//check the key back to the start if needed

                char character = ciphertext[i];
                char keyLetter = key[j];
                int shift = Convert.ToInt32(keyLetter) - 97;
                letter = Convert.ToChar(CeaserCipher.DecryptCC(character.ToString(), shift));//ceaser shift the characters back

                plaintext += letter;
            }
            return plaintext;
        }
    }

    class Vernam
    {

        static string GenerateRandom(int length)//generate key length of the text
        {
            Console.WriteLine(length);
            Random rnd = new Random();
            char[] randomstring = new char[length];//new char[] for key
            for (int i = 0; i < length; i++)
            {
                randomstring[i] = Convert.ToChar(rnd.Next(97, 122));//character generation
            }
            string output = new string(randomstring);
            return output;
        }


        public static string EncryptVe(string plaintext, ref string key)
        {
            string ciphertext;

            key = GenerateRandom(plaintext.Length);//generate key

            char[] cipherChar = new char[plaintext.Length];

            Console.WriteLine("key: {0}", key.Length);//display the key

            for (int i = 0; i < plaintext.Length; i++)//over each character
            {
                int letter = plaintext[i] ^ key[i];//xor the characters
                cipherChar[i] = Convert.ToChar(letter + 97);
            }
            ciphertext = new string(cipherChar);//get it to the string
            return ciphertext;
        }

        public static string DecryptVe(string ciphertext, string key)
        {
            string plaintext;

            char[] plainChar = new char[ciphertext.Length];//get array for the new plaintext

            for (int i = 0; i < ciphertext.Length; i++)//for every character
            {
                int letter = ciphertext[i] ^ key[i];//xor them
                plainChar[i] = Convert.ToChar(letter);//add to char[]
            }
            plaintext = new string(plainChar);//to string
            return plaintext;
        }
    }
}
