namespace LearningObjects
{

    public class Program
    {
        static void Main(string[] args)
        {
            /*task 1*/
            CheckNumber(5);
            CheckNumber(-2);
            CheckNumber(0);
            Console.WriteLine("///////////////////////////////////////////");
            /*task 2*/
            Console.WriteLine(HighestValue(2, 5, 2));
            Console.WriteLine(HighestValue(2, 5, 3));
            Console.WriteLine(HighestValue(2, 2, 2));
            Console.WriteLine("///////////////////////////////////////////");
            /*task 3*/
            CheckSymbol("a");
            CheckSymbol("b");
            Console.WriteLine("///////////////////////////////////////////");
            /*task 4*/
            LeapYear(2020);
            LeapYear(2021);
            LeapYear(2022);
            LeapYear(2023);
            LeapYear(2024);
            Console.WriteLine("///////////////////////////////////////////");
            /*task 5*/
            SymbolIsNumber('a');
            SymbolIsNumber('2');
            Console.WriteLine("///////////////////////////////////////////");
            /*task 6*/
            CheckTimeInput(25, 61);
            CheckTimeInput(27, 59);
            CheckTimeInput(22, 61);
            CheckTimeInput(8, 55);
            CheckTimeInput(15, 22);
            CheckTimeInput(7, 15);
            Console.WriteLine("///////////////////////////////////////////");
            /*task 7*/
            CheckNumberOfThreeDigits(5);
            CheckNumberOfThreeDigits(111);
            CheckNumberOfThreeDigits(99);
            CheckNumberOfThreeDigits(100);
            CheckNumberOfThreeDigits(1000);
            CheckNumberOfThreeDigits(999);
            Console.WriteLine("///////////////////////////////////////////");
            /*task 8*/
            CheckCharIfUpper('a');
            CheckCharIfUpper('A');
            CheckCharIfUpper('0');
            CheckCharIfUpper('5');
        }

        /* task 1 */
        public static void CheckNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Teigiamas");
            }
            else if (number < 0)
            {
                Console.WriteLine("Neigiamas");
            }
            else
            {
                Console.WriteLine("Nulis");
            }


        }

        /* task 2 */
        public static int HighestValue(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else if (num3 > num1 && num3 > num2)
            {
                return num3;
            }
            else
            {
                Console.WriteLine("Error, maybe all number are equal");
                return 0;

            }

        }

        /* task 3 */
        public static void CheckSymbol(string symbol)
        {
            if (symbol == "a" || symbol == "e" || symbol == "i" || symbol == "u" || symbol == "o")
            {
                Console.WriteLine("Balsė");
            }
            else
            {
                Console.WriteLine("Priebalsė");
            }
        }

        /* task 4 */

        public static void LeapYear(int year)
        {
            if (year % 4 == 0)
            {
                Console.WriteLine("Keliamieji metai");
            }
            else
            {
                Console.WriteLine("Ne keliamieji metai");
            }

        }

        /* task 5 */
        public static bool SymbolIsNumber(char symbol)
        {
            if (symbol == '0' ||
                symbol == '1' ||
                symbol == '2' ||
                symbol == '3' ||
                symbol == '4' ||
                symbol == '5' ||
                symbol == '6' ||
                symbol == '7' ||
                symbol == '8' ||
                symbol == '9')
            {
                Console.WriteLine("Skaičius");
                return true;
            }
            else
            {
                Console.WriteLine("Ne skaičius");
                return false;
            }
        }

        /* task 6 */
        public static void CheckTimeInput(int hours, int minutes)
        {
            if ((hours <= 23 && hours >= 0) && (minutes <= 59 && minutes >= 0))
            {
                Console.WriteLine("Teisinga įvestis");
            }
            else { Console.WriteLine("Neteisinga įvestis"); }
        }

        /*task 7*/
        public static void CheckNumberOfThreeDigits(int number) {
            if (number >= 100 && number < 1000)
            {
                Console.WriteLine("Trijų skaitmenų skaičius");
            } else { Console.WriteLine("Ne trijų skaitmenų skaičius"); }
        }

        /*task 8*/
        public static void CheckCharIfUpper(char symbol) {
            if (char.IsUpper(symbol)) {
                Console.WriteLine("Didžioji raidė");
            } else if(char.IsLower(symbol))
            {
                Console.WriteLine("Ne didžioji raidė");
            } else if (char.IsNumber(symbol))
            {
                Console.WriteLine("Skaičius");
            }
        }
    }
}