using System;

namespace PalindromeSearch
{
    class Program
    {
        static bool IsPalindromeReverse(string text)
        {
            //this function returns a boolean value depending if the input text is a palindrome or not
            //it takes the string and reverses it, then compares it to the origional
            //if they are the same then the origional text is a palindrome and true is reurned
            //if not, then false is returned
            string textReverse = Reverse(text);//reverse the string
            bool qPalindrome;
            if (text == textReverse)//if else for deciding the return value
            {
                qPalindrome = true;
            }
            else
            {
                qPalindrome = false;
            }
            return qPalindrome;
        }

        static string Reverse(string s)
        {
            //this function returns the reverse of the input string
            char[] charArray = s.ToCharArray();//into char[]
            Array.Reverse(charArray);//reverse it
            return new string(charArray);// convert back and return
        }

        static bool isPalindromeCompare(string text)
        {
            //this function checks if the input text is a palindrome or not
            //it checks the index 0 of the string with the last, if they are the same then it continues
            //it repeats this doing index 1 and the 2nd to last until the middle is reached or passed
            //if it gets to this point then it is a palindrome
            //if it fails at any point then it is not a palindrome
            int start = 0;
            int end = text.Length - 1;
            bool qPalindrome;
            while (text[start] == text[end] && start < end)//loop over each char pair
            {
                start++;
                end--;
            }
            if (end < start)//if else for deciding the return value
            {
                qPalindrome = true;
            }
            else
            {
                qPalindrome = false;
            }
            return qPalindrome;
        }
        static void ConvertBlankAndLower(ref string text)
        {
            text = text.ToLower();
            text = text.Replace(" ", "");
        }

        public static void DisplayMenu()
        {
            //this fucntion displays the options for the menu function
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Reverse and compare");
            Console.WriteLine("2. check first to last and repeat");
            Console.Write("Enter option --> ");
        }

        public static int Menu()
        {
            //this menu accepts only 0, 1 and 2 as inputs, if not it loops until one of those is chosen
            int option;
            bool validUserInput;
            do
            {
                DisplayMenu();
                validUserInput = int.TryParse(Console.ReadLine(), out option);
            } while (!validUserInput || option < -1 || option > 3);

            return option;
        }

        static void Main(string[] args)
        {
            //main function
            //var delcaration and initialisation
            bool exit = false;
            while (exit == false) // loop until user quits
            {
                int option = Menu();//get  the menu option
                if (option == 1)//1 selected then the reverse function executes
                {
                    Console.Write("Enter the string to check --> ");
                    string text = Console.ReadLine();
                    ConvertBlankAndLower(ref text);
                    bool qPalindrome = IsPalindromeReverse(text);
                    if (qPalindrome == true)
                    {
                        Console.WriteLine("is Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("not Palindrome");
                    }
                }
                else if (option == 2)//2 is selected and the compare function executes
                {
                    Console.Write("Enter the string to check --> ");
                    string text = Console.ReadLine();
                    ConvertBlankAndLower(ref text);
                    bool qPalindrome = isPalindromeCompare(text);
                    if (qPalindrome == true)
                    {
                        Console.WriteLine("is Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("not Palindrome");
                    }
                }
                else// else case 0, then exit the while loop
                {
                    exit = true;
                }
            }
            
        }
    }
}
