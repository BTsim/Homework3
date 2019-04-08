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

        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {

        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {

        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {

        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {

        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {

        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {

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
            Console.WriteLine("площадь круга="+a1);
            

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
