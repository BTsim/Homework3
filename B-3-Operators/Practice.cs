using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
            Console.WriteLine("Enter first number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            var summ = number1 + number2;
            Console.WriteLine(number1+"+"+number2+"="+summ);

        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            Console.WriteLine("Enter first number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            var summ = number1 + number2;
            Console.WriteLine("Enter the answer");
            double answer = Convert.ToDouble(Console.ReadLine());
            if (answer == summ)
            {
                Console.WriteLine("Answer is wright");
            }
            else
            {
                Console.WriteLine("Answer is wrong, wright answer is "+summ);
            }
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            Console.WriteLine("Enter first number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            var summ = number1 + number2;
            Console.WriteLine("Enter the answer");
            double answer = Convert.ToDouble(Console.ReadLine());
            if (answer == summ)
            {
                Console.WriteLine("Answer is wright");
            }
            else if (answer < summ)
            {
                Console.WriteLine("Answer is wrong, wright answer is bigger");
            }
            else
            {
                Console.WriteLine("Answer is wrong, wright answer is less");
            }

        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            Console.WriteLine("Enter first number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator (+ or -)");
            string oper = Console.ReadLine();
            double summ;
            if (oper == "-")
            {
                summ = number1 - number2;
            }
            else
            {
                summ = number1 + number2;
            }
            Console.WriteLine("Enter the answer");
            double answer = Convert.ToDouble(Console.ReadLine());
            if (answer == summ)
            {
                Console.WriteLine("Answer is wright");
            }
            else if (answer < summ)
            {
                Console.WriteLine("Answer is wrong, wright answer is bigger");
            }
            else
            {
                Console.WriteLine("Answer is wrong, wright answer is less");
            }

        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
            Console.WriteLine("Enter first number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator (+ or -)");
            string oper = Console.ReadLine();
            double summ;
            if (oper == "-")
            {
                summ = number1 - number2;
            }
            else
            {
                summ = number1 + number2;
            }
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Enter the answer");
                double answer = Convert.ToDouble(Console.ReadLine());
                if (answer == summ)
                {
                    Console.WriteLine("Answer is wright");
                    i = 3;
                }
                else if (answer < summ)
                {
                    Console.WriteLine("Answer is wrong, wright answer is bigger");
                    i++;
                }
                else
                {
                    Console.WriteLine("Answer is wrong, wright answer is less");
                    i++;
                }

            }
        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {
            double summ=0;
            string oper="+";
            int i = 0;
            Console.WriteLine("Enter " +1+ " number");
            double number = Convert.ToDouble(Console.ReadLine());
            summ = number;
            for (i = 0; i < 4; i++)
            {
                if (i < 4)
                {
                    Console.WriteLine("Enter " + (i + 1) + " operator (+ or -)");
                    oper = Console.ReadLine();
                }
                Console.WriteLine("Enter "+(i+2)+" number");
                number = Convert.ToDouble(Console.ReadLine());
                if (oper == "-")
                {
                    summ -=number;
                }
                else
                {
                    summ += number;
                }
            }
            i = 0;
            while (i < 3)
            {
                Console.WriteLine("Enter the answer");
                double answer = Convert.ToDouble(Console.ReadLine());
                if (answer == summ)
                {
                    Console.WriteLine("Answer is wright");
                    i=3;
                }
                else if (answer < summ)
                {
                    Console.WriteLine("Answer is wrong, wright answer is bigger");
                    i++;
                }
                else
                {
                    Console.WriteLine("Answer is wrong, wright answer is less");
                    i++;
                }

            }


        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
            //Вывод и правильности решения задачи реализован во всех предыдущих алгоритмах, где требовалось ввести решение самостоятельно
        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {
            string r = Console.ReadLine();
            int r1 = Convert.ToInt32(r);
            double a = Math.PI * r1 * r1;
            string a1 = Convert.ToString(a);
            Console.WriteLine("площадь круга=" + a1);


        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
            double amount = 0;

            double persent = 0;

            double years = 0;

            double AllSum = 0;

            string amountStr, persentStr, yearsStr;



            Console.Write("Желаемая сумма кредита?(руб)");

            amountStr = Console.ReadLine();

            amount = double.Parse(amountStr);

            if (amount <= 0)

            {

                Console.WriteLine("Сумма должна быть > 0");

                amount = 0;

            }



            Console.Write("Процентная ставка?(%)");

            persentStr = Console.ReadLine();

            persent = double.Parse(persentStr);

            if (persent <= 0)

            {

                Console.WriteLine("Процент должен быть >0");

                persent = 0;

            }



            Console.Write("На сколько лет кредит?");

            yearsStr = Console.ReadLine();

            years = double.Parse(yearsStr);

            if (years <= 0)

            {

                Console.WriteLine("Минимальный срок кредитования - 1 год");

                years = 0;

            }

            double numberofmonths = 12 * years;

            double loanbody = (amount / numberofmonths);

            double persentDec = persent / 100;

            Console.WriteLine("Выплаты по месяцам");

            for (int i = 0; i < numberofmonths; i++)

            {

                double amountMonth = (amount - loanbody * i) * persentDec / 365 * 30 + loanbody;

                int month = i + 1;

                Console.WriteLine(String.Format("В " + month + " месяц Ваш платеж составит " + Math.Round(amountMonth, 2)));

                AllSum = AllSum + Math.Round(amountMonth, 2);

            }

            Console.WriteLine("Всего выплаты составят " + (AllSum));

            double overpayment = AllSum - amount;

            Console.WriteLine("Всего переплата составит " + Math.Round(overpayment, 2));

        }
    }
}
