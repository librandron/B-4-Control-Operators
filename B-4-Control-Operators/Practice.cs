using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
            var morningStart = TimeSpan.Parse("06:00");
            var morningStop = TimeSpan.Parse("11:59");

            var dayStart = TimeSpan.Parse("12:00");
            var dayStop = TimeSpan.Parse("18:00");

            var eveningStart = TimeSpan.Parse("18:01");
            var eveningStop = TimeSpan.Parse("23:59");

            var time = DateTime.Now.TimeOfDay;
            

            if (time > eveningStart && time < eveningStop)
            {
                Console.WriteLine("Good evening Olga");
            }
            else
            {
                if (time > dayStart && time < dayStop)
                {
                    Console.WriteLine("Good day Olga");
                }
                else
                {
                    if (time > morningStart && time < morningStop)
                    {
                        Console.WriteLine("Good Morning olga");
                    }
                }
            }         


            Console.WriteLine(time);

            Console.ReadKey();
        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
            int firstNumber, secondNumber;

            Console.WriteLine("Enter first number:");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine($"{firstNumber} = {secondNumber}");
            }
            else
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine($"{firstNumber} > {secondNumber} на {firstNumber - secondNumber}");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} < {secondNumber} на {secondNumber - firstNumber}");
                }
            }

        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
            int firstNumber, secondNumber;

            Console.WriteLine("Enter first number:");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber >= 0 && secondNumber >= 0)
            {
                if (firstNumber == secondNumber)
                {
                    Console.WriteLine($"{firstNumber} = {secondNumber}");
                }
                else
                {
                    if (firstNumber > secondNumber)
                    {
                        Console.WriteLine($"{firstNumber} > {secondNumber} на {firstNumber - secondNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} < {secondNumber} на {secondNumber - firstNumber}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your numbers below zero");
            } 
        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {

        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
            var today = DateTime.Today;
            var dayOfWeek = (int)today.DayOfWeek;
            switch (dayOfWeek)
            {
                case 0:
                    Console.WriteLine("Good Sunday Olga");
                    break;
                case 1:
                    Console.WriteLine("Good Monday Olga");
                    break;
                case 2:
                    Console.WriteLine("Good Tuesday Olga");
                    break;
                case 3:
                    Console.WriteLine("Good Wednesday Olga");
                    break;
                case 4:
                    Console.WriteLine("Good Thursday Olga");
                    break;
                case 5:
                    Console.WriteLine("Good Friday Olga");
                    break;
                case 6:
                    Console.WriteLine("Good Saturday Olga");
                    break;
            }

        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {

            Labeltart:

            var button = Console.ReadKey();

            switch (button.KeyChar)
            {
                case 'w':
                case 'W':
                    Console.WriteLine("\nUP");
                    break;
                case 'a':
                case 'A':
                    Console.WriteLine("\nLEFT");
                    break;
                case 's':
                case 'S':
                    Console.WriteLine("\nDOWN");
                    break;
                case 'd':
                case 'D':
                    Console.WriteLine("\nRIGHT");
                    break;
            }
            goto Labeltart;

        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            for (var i = 1; i <=10; i++)
            {
                var ostatok = i % 2;
                if (ostatok == 0)
                {
                    Console.WriteLine($"{i} четное");
                }
                else
                {
                    Console.WriteLine($"{i} нечетное");
                }
            }
        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
           
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
           
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            Console.WriteLine("Enter Number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("operand (+, -, * or /)");
            var operand = Console.ReadLine();

            Console.WriteLine("Enter Number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (operand == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else
            {
                if (operand == "-")
                {
                    Console.WriteLine(number1 - number2);
                }
                else
                {
                    if (operand == "*")
                    {
                        Console.WriteLine(number1 * number2);
                    }
                    else
                    {
                        if (number2 != 0)
                        {
                            Console.WriteLine(number1 / number2);
                        }else
                        {
                            Console.WriteLine("Divizion by zero");
                        }
                    }
                }
            }

        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            Console.WriteLine("Enter Number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("operand (+, -, * or /)");
            var operand = Console.ReadLine();
 
            Console.WriteLine("Enter Number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());



            switch (operand)
            {
                case "+":
                    Console.WriteLine(number1 + number2);
                    break;
                case "-":
                    Console.WriteLine(number1 - number2);
                    break;
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;
                case "/":
                    {
                        if (number2 == 0)
                        {
                            Console.WriteLine("division by zero");
                            break;
                        } else
                        {
                            Console.WriteLine(number1 / number2);
                        }
                        break;
                    }
            }
                    
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            Console.WriteLine("Enter some word:");
            string word = Console.ReadLine();
            int size = word.Length;

            //foreach (char letter in word)
            //{

            //    Console.WriteLine(word[size - 1]);
            //    size = size - 1;
            //}

            while (size != 0)
            {
                Console.WriteLine(word[size - 1]);
                size--;
            }
                
            

        }

        



    }
}
