using System;

namespace Project003
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(" ");
            Console.WriteLine("MOSH CLASS");
            Console.WriteLine(" ");
            var number = 2;
            var count = 10;
            var totalPrice = 10;
            var character = 'A';
            var firstName = "Azlan";
            var isWorking = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine(" ");
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            var numberA = "1234";
            int iA = Convert.ToInt32(numberA);
            Console.WriteLine(iA);

            Console.WriteLine(" ");
            try
            {
                var numberB = "1234";
                byte c = Convert.ToByte(numberB);
                Console.WriteLine(c);
            }
            catch (Exception)
            { Console.WriteLine("Error Exist 1."); }
            try
            {
                string str = "true";
                bool d = Convert.ToBoolean(str);
                Console.WriteLine(d);
            }
            catch (Exception)
            { Console.WriteLine("Error Exist 2."); }

            Console.WriteLine(" ");
            var e = 1;
            var f = 2;
            var g = 3;
            Console.WriteLine(g > f && f > e);

            Console.WriteLine(" ");
            Console.WriteLine("MIKE DANE");

            Console.WriteLine("COCAT");
            string characterName = "John";
            int characterAge;
            characterAge = 35;
            Console.WriteLine("There omce was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + "years old.");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didnt like being " + characterAge);

            Console.WriteLine(" ");
            Console.WriteLine("INDEX");
            string phrase = "Azlan Academy";
            Console.WriteLine(phrase.IndexOf('z'));
            string phrase5 = "Mohd Azlan Abas";
            Console.WriteLine(phrase5.Substring(8, 3));

            Console.WriteLine(" ");
            Console.WriteLine("DATA TYPES");
            string phraseB = "Azlan Academy";
            char grade = 'A';
            int age = 35;
            double gpa = 3.5;
            bool isMale = true;
            Console.WriteLine(phraseB + " " + grade + " " + age + " " + gpa + " " + isMale);

            /*Console.WriteLine("");
            Console.WriteLine("INPUT -2 ");
            Console.Write("Enter a number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);

            Console.WriteLine("");
            Console.WriteLine("INPUT2  + CONCAT - 3");
            Console.Write("Enter your name : ");
            string name3 = Console.ReadLine();
            Console.Write("Enter your age : ");
            string age3 = Console.ReadLine();
            Console.WriteLine("Hello " + name3 + " you are " + age3 + " years old");

            Console.WriteLine("");
            Console.WriteLine("CONCAT");
            string color, pluralNoun, celebrity;
            Console.Write("Enter a color : ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun : ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity name : ");
            celebrity = Console.ReadLine();
            Console.WriteLine("The Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);*/

            Console.WriteLine("");
            Console.WriteLine("ARRAYS INTRO");
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Kelly";
            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine(luckyNumbers[1]);

            Console.WriteLine("");
            Console.WriteLine("RETURN");
            Console.WriteLine(cube(5));

            Console.WriteLine("");
            Console.WriteLine("METHOD");
            SayHi("Mike", 33);
            SayHi("Jonh", 56);
            SayHi("Tom", 12);

            Console.WriteLine("");
            Console.WriteLine("ARRAY LENGTH");
            int[] luckyNumbers2 = { 4, 8, 15, 16, 23, 42 };
            for (int k = 0; k < luckyNumbers2.Length; k++)
            { Console.WriteLine(luckyNumbers[k]); }

            Console.WriteLine(" ");
            Console.WriteLine("If-Statement-isMale");
            bool isMale2 = false;
            bool isTall2 = false;
            if (isMale2 && isTall2)
            {
                Console.WriteLine("You are male and you are tall");
            }
            else if (!isMale2 & isTall2)
            {
                Console.WriteLine("You are a short male :( ");
            }
            else
            {
                Console.WriteLine("You maybe are a tall or short female");
            }

            Console.WriteLine(" ");
            Console.WriteLine("SWITCH STATEMENT");
            Console.WriteLine(GetDay(3));

            Console.WriteLine(" ");
            Console.WriteLine("WHILE LOOP- GUESSING GAME");

            string secretWord = "azlan";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses) {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
        }
        if (outOfGuesses)
            {
            Console.Write("You Loose");
            } else { Console.Write("You Win"); }














            // METHODS AREA

        }
        static string GetDay(int dayNum) {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Frinday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "invalid Day Number";
                    break;
            }
                    return dayName;

        }
        static void SayHi(string name4, int age4)
{
        Console.WriteLine("Hello " + name4 + " your age is " + age4);
}
        static int cube(int num)
{
    int result3 = num * num * num;
    return result3;
}
    }
}