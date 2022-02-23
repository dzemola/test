using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;



namespace Text_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            backwardsString();
            sentenceCapitalizer();
            letterCounter();
            sumofDigits();
            freqChar();
            //phoneNumber();
            
        }
        static void backwardsString()
        {
            //Setting a path for the file to go to and variables
            string path = "C:\\Users\\jelly\\OneDrive\\Desktop\\backwardstring.txt";
            //StreamWriter writer = new StreamWriter(path);
            string fString = "";
            string revString = "";

            //Have user enter a word and save it to a variable
            Console.WriteLine("Please enter a word.");
            fString = Console.ReadLine();


            //Use a char arrary to reverse the string then turn the char to a string
            char[] rString = fString.ToCharArray();
            Array.Reverse(rString);
            revString = new string(rString);

            try
            {
                File.WriteAllText(path, revString);
                Console.WriteLine("File written: " + path);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

        }
        static void sentenceCapitalizer()
        {
            //Setting a path for the file to go to and variables
            string path = "C:\\Users\\jelly\\OneDrive\\Desktop\\capsentence.txt";
            string phrase = "";

            //Gettiong the user to enter a string of sentences with all lower case letters.
            Console.WriteLine("Please enter a few sentences using lower case letters at the beginning of each sentence.");
            phrase = Console.ReadLine();

            //Set a bool for the if/else statement
            bool IsNewSentence = true;

            //Use a string builder to connect all the sentences
            var result = new StringBuilder(phrase.Length);

            //The for loop wiil be used with the string builder to capitalize the first letter of ech sentence
            for (int i = 0; i < phrase.Length; i++)
            {
                if (IsNewSentence && char.IsLetter(phrase[i]))
                {
                    result.Append(char.ToUpper(phrase[i]));
                    IsNewSentence = false;
                }
                else
                    result.Append(phrase[i]);

                if (phrase[i] == '!' || phrase[i] == '?' || phrase[i] == '.')
                {
                    IsNewSentence = true;
                }
            }

            //Printing/ saving it to the desktop
            if (File.Exists(path))
            {

                Console.WriteLine("File already Exsists: " + path);
            }
            else
            {
                //insert statement that attempts to write a text file and confirm success, advise of failure
                try
                {
                    File.WriteAllText(path, result.ToString());
                    Console.WriteLine("File written: " + path);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }


            }

        }
        static void letterCounter()
        {
            //Set path and variables
            string path = "C:\\Users\\jelly\\OneDrive\\Desktop\\lettercounter.txt";
            string userString = "";
            int vowel = 0;
            int consonants = 0;
            int length = 0;


            //Get user input
            Console.WriteLine("Enter a sentence and then it will display the number of vowels and consonants in the sentence.");
            userString = Console.ReadLine();

            length = userString.Length;

            for (int i = 0; i < length; i++)
            {

                // Check if the charator is a vowel
                if (userString[i] == 'a' || userString[i] == 'e' ||
                    userString[i] == 'i' || userString[i] == 'o' ||
                    userString[i] == 'u' || userString[i] == 'A' ||
                    userString[i] == 'E' || userString[i] == 'I' ||
                    userString[i] == 'O' || userString[i] == 'U')
                {

                    // Increment the vowels
                    vowel++;
                }

                // Check if the character is a alphabet
                // other than vowels
                else if ((userString[i] >= 'a' && userString[i] <= 'z') ||
                         (userString[i] >= 'A' && userString[i] <= 'Z'))
                {

                    // Increment the consonants
                    consonants++;
                }
            }

            // Display the count of vowels and consonant
            Console.WriteLine("count of vowel = " + vowel);
            Console.WriteLine("count of consonant = " + consonants);


            //Setting up the configuration to display correctly
            string result = userString;
            result += "\r\ncount of vowel = " + vowel;
            result += "\r\ncount of consonant = " + consonants;

            //Printing/ saving it to the desktop
            if (File.Exists(path))
            {

                Console.WriteLine("File already Exsists: " + path);
            }
            else
            {
                //insert statement that attempts to write a text file and confirm success, advise of failure
                try
                {
                    File.WriteAllText(path, result);
                    Console.WriteLine("File written: " + path);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }


            }

        }
        static void sumofDigits()
        {
            //Set path and variables
            string path = "C:\\Users\\jelly\\OneDrive\\Desktop\\sumofdigits.txt";
            string str = "";
            string newStr = "";

            // holds sum of all numbers
            // present in the string
            int sum = 0;

            Console.WriteLine("Please enter a series of numbers.");
            str = Console.ReadLine();
            int num = int.Parse(str);

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            newStr = "\r\nYou entered " + str;
            newStr += "\r\nYour total is " + sum.ToString();

            Console.WriteLine(newStr);

            //Printing/ saving it to the desktop
            if (File.Exists(path))
            {

                Console.WriteLine("File already Exsists: " + path);
            }
            else
            {
                //insert statement that attempts to write a text file and confirm success, advise of failure
                try
                {
                    File.WriteAllText(path, newStr);
                    Console.WriteLine("File written: " + path);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }


            }

        }
        static void freqChar()
        {
            //Variable & set path
            string path = "C:\\Users\\jelly\\OneDrive\\Desktop\\freqChar.txt";
            int[] charCount = new int[256];
            string newStr = "";

            //Getting the user input
            Console.WriteLine("Enter a word.");
            String str = Console.ReadLine();
            int length = str.Length;

            for (int i = 0; i < length; i++)
            {
                charCount[str[i]]++;
            }
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < length; i++)
            {
                if (maxCount < charCount[str[i]])
                {
                    maxCount = charCount[str[i]];
                    character = str[i];
                }
            }


            Console.WriteLine("The string is: " + str);
            Console.WriteLine("The highest occurring character in the above string is: " + character);
            Console.WriteLine("Number of times this character occurs: " + maxCount);


            newStr = "\r\nThe string is: " + str;
            newStr += "\r\nThe highest occurring character in the above string is: " + character;
            newStr += "\r\nNumber of times this character occurs: " + maxCount;

            //Printing/ saving it to the desktop
            if (File.Exists(path))
            {

                Console.WriteLine("File already Exsists: " + path);
            }
            else
            {
                //insert statement that attempts to write a text file and confirm success, advise of failure
                try
                {
                    File.WriteAllText(path, newStr);
                    Console.WriteLine("File written: " + path);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }
        /*static void phoneNumber()
        {
            //Variable and set path
            string path = "C:\\Users\\jelly\\OneDrive\\Desktop\\phoneNumber.txt";
            var phone = " ";
            int pos = 0;
            

                Console.WriteLine("Please enter a phone number that uses letters also, in the format xxx-xxx-xxxx");
            phone = Console.ReadLine();

            

            Dictionary<Char, Char[]> lettersMap = new Dictionary<Char, char[]>();
            lettersMap.Add('1', null);
            lettersMap.Add('2', new[] { 'a', 'b', 'c' });
            lettersMap.Add('3', new[] { 'd', 'e', 'f' });
            lettersMap.Add('4', new[] { 'g', 'h', 'i' });
            lettersMap.Add('5', new[] { 'j', 'k', 'l' });
            lettersMap.Add('6', new[] { 'm', 'n', 'o' });
            lettersMap.Add('7', new[] { 'p', 'q', 'r', 's' });
            lettersMap.Add('8', new[] { 't', 'u', 'v' });
            lettersMap.Add('9', new[] { 'w', 'x', 'y', 'z' });
            lettersMap.Add('0', null);
            
            


            //Printing/ saving it to the desktop
            if (File.Exists(path))
            {

                Console.WriteLine("File already Exsists: " + path);
            }
            else
            {
                //insert statement that attempts to write a text file and confirm success, advise of failure
                try
                {
                    File.WriteAllText(path, result.ToString());
                    Console.WriteLine("File written: " + path);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }


        }*/
        
    }
}
    


