using System.IO;
using System;

namespace FileEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            //get whether they want to encrypt or decrypt
            int EncrypOrDecryp = Other.EncDec();

            if (EncrypOrDecryp == 1)//encrypt
            {
                Console.Write("Please enter the full path of the file --> ");//get the path of the plaintext
                string filePath = Console.ReadLine();

                int option = Other.Menu();//get the encryption method
                if (option == 1)//ceaser cipher
                {
                    if (File.Exists(@filePath))//check for file
                    {
                        string plaintext = File.ReadAllText(@filePath);
                        Console.WriteLine("Current content of the file {0}", plaintext);//get content of the file

                        Console.Write("Enter the shift value --> ");//get the shift wanted
                        int shift = int.Parse(Console.ReadLine());
                        string ciphertext = EcDc.CeaserCipher.EncryptCC(plaintext, shift);//shift it

                        Console.Write("Enter the full path of the new file you would like to create --> ");//the new file created
                        string exitFilePath = Console.ReadLine();

                        Console.WriteLine("New content: {0}", ciphertext);//display the new content to be saves

                        File.WriteAllText(@exitFilePath, ciphertext);//save the file
                    }
                }
                else if (option == 2)//vigeneere
                {
                    if (File.Exists(@filePath))
                    {
                        string plaintext = File.ReadAllText(@filePath);//get the content of the file
                        Console.WriteLine("Current content of the file {0}", plaintext);

                        Console.Write("Enter the shift text --> ");//get the shift text
                        string shift = Console.ReadLine();
                        string ciphertext = EcDc.Vigeneere.EncryptVi(plaintext, shift);//shift all of the character

                        Console.Write("Enter the full path of the new file you would like to create --> ");//get the address of the new file
                        string exitFilePath = Console.ReadLine();

                        Console.WriteLine("New content: {0}", ciphertext);//display new content

                        File.WriteAllText(@exitFilePath, ciphertext);//write the new content
                    }
                }
                else if (option == 3)//verman OTP
                {
                    if (File.Exists(@filePath))
                    {
                        string plaintext = File.ReadAllText(@filePath);//get content
                        Console.WriteLine("Current content of the file {0}", plaintext);

                        string key = "";
                        string ciphertext = EcDc.Vernam.EncryptVe(plaintext, ref key);//generate key and encrypt

                        Console.Write("Enter the full path of the new file you would like to create --> ");
                        string exitFilePath = Console.ReadLine();

                        Console.Write("Enter the full path of the new file you would like to create for the key --> ");//get the new key file
                        string exitKeyPath = Console.ReadLine();

                        Console.WriteLine("New content: {0}", ciphertext);//display the new content

                        File.WriteAllText(@exitFilePath, ciphertext);//write the new content
                        File.WriteAllText(exitKeyPath, key);//write the key to a file
                    }
                }
            }
            else if (EncrypOrDecryp == 2)//decrypt
            {
                Console.Write("Please enter the full path of the file --> ");//get the ciphertext file
                string filePath = Console.ReadLine();

                int option = Other.Menu();//get method
                if (option == 1)//ceaser
                {
                    if (File.Exists(@filePath))
                    {
                        string ciphertext = File.ReadAllText(@filePath);//get content
                        Console.WriteLine("Current content of the file {0}", ciphertext);

                        Console.Write("Enter the shift value --> ");//get the shift value
                        int shift = int.Parse(Console.ReadLine());
                        string plaintext = EcDc.CeaserCipher.DecryptCC(ciphertext, shift);//decrypt the ciphertext

                        Console.Write("Enter the full path of the new file you would like to create --> ");//get the new file path
                        string exitFilePath = Console.ReadLine();

                        Console.WriteLine("New content: {0}", plaintext);//display new content

                        File.WriteAllText(@exitFilePath, plaintext);//write new content
                    }
                }
                else if (option == 2)//vigeneere
                {
                    if (File.Exists(@filePath))
                    {
                        string ciphertext = File.ReadAllText(@filePath);//get content of the file
                        Console.WriteLine("Current content of the file {0}", ciphertext);

                        Console.Write("Enter the shift text --> ");//get the shift text
                        string shift = Console.ReadLine();
                        string plaintext = EcDc.Vigeneere.DecryptVi(ciphertext, shift);//decrypt with key

                        Console.Write("Enter the full path of the new file you would like to create --> ");//get new file path
                        string exitFilePath = Console.ReadLine();

                        Console.WriteLine("New content: {0}", plaintext);//display new content

                        File.WriteAllText(@exitFilePath, plaintext);//write new content
                    }
                }
                else if (option == 3)//vernam OTP
                {
                    if (File.Exists(@filePath))
                    {
                        string ciphertext = File.ReadAllText(@filePath);//get content
                        Console.WriteLine("Current content of the file {0}", ciphertext);

                        Console.Write("Enter the full path of the key file --> ");//get the key from the file
                        string keyPath = Console.ReadLine();
                        string key = File.ReadAllText(@keyPath);//
                        Console.WriteLine("Current content of the file {0}", key);

                        string plaintext = EcDc.Vernam.DecryptVe(ciphertext, key);//decrypt the ciphertext

                        Console.Write("Enter the full path of the new file you would like to create --> ");//get new file location
                        string exitFilePath = Console.ReadLine();

                        Console.WriteLine("New content: {0}", plaintext);//display new content

                        File.WriteAllText(@exitFilePath, plaintext);//write new content

                    }
                }
            }           
        }

    }
    class Other
    {
        public static int Menu()//menu function
        {
            int option;
            bool validUserInput;
            do
            {//display options
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Ceaser Cipher");
                Console.WriteLine("2. Vigenere Cipher");
                Console.WriteLine("3. Vernam Cipher");

                validUserInput = int.TryParse(Console.ReadLine(), out option);//look for specific values
            } while (!validUserInput || option < -1 || option > 4);

            return option;
        }

        public static int EncDec()//the other menu, same as other one but different options
        {
            int option;
            bool validUserInput;
            do
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Encrypt");
                Console.WriteLine("2. Decrypt");
                validUserInput = int.TryParse(Console.ReadLine(), out option);
            } while (!validUserInput || option < -1 || option > 3);

            return option;
        }
    }
}