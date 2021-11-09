using System;

namespace Unit1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Case3();
            //Case4();
            Case5();
            Console.ReadLine();
        }

        //Задание 1.3: 
        //Определите переменные всех возможных примитивных типов С# и  проинициализируйте их. 
        //Осуществите ввод и вывод их значений используя консоль.
        static void Case3()
        {
            Console.WriteLine("Case 1.3");

            Console.Write("int i = ");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.Write("double d = ");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.Write("decimal dc = ");
            decimal dc = Convert.ToDecimal(Console.ReadLine());

            Console.Write("char c = ");
            char c = Convert.ToChar(Console.ReadLine());

            Console.Write("string s = ");
            string s = Console.ReadLine();

            Console.Write("bool b = ");
            bool b = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("i = " + i + ", d = " + d + ", dc = " + dc + ", c = " + c + ", s = " + s + ", b = " + b);
        }

        //Задание 1.4: 
        //Выполните упаковку и распаковку значимых типов.
        static void Case4()
        {
            Console.WriteLine("Case 1.4");

            object obj;

            int i1 = 7;
            double d1 = 2.5;
            decimal dc1 = 3.5m;
            char c1 = 'a';
            bool b1 = false;

            obj = i1;
            int i2 = (int)obj;

            obj = d1;
            double d2 = (double)obj;

            obj = dc1;
            decimal dc2 = (decimal)obj;

            obj = c1;
            char c2 = (char)obj;

            obj = b1;
            bool b2 = (bool)obj;

            Console.WriteLine("Checking:");
            Console.WriteLine(i1 + " " + d1 + " " + dc1 + " " + c1 + " " + b1);
            Console.WriteLine(i2 + " " + d2 + " " + dc2 + " " + c2 + " " + b2);
        }

        //Задание 1.5: 
        //Провести вычисления и вывести результаты в консоль
        //1. Сколько мне будет лет в 2025?
        //2. Сколько мне было бы лет, если бы я родился в 1917?
        //3. Сколько мне было бы лет, если бы в одном году было 100 дней?
        //4. Я купил 100$ по курсу 2,57р.Сколько я выиграю в рублях, если сдам их сегодня по курсу 2,78р?
        static void Case5()
        {
            Console.WriteLine("Case 1.5");

            Console.WriteLine("1:");
            int yearBirth = 1995;
            int yearFuture = 2025;
            int ageFuture = yearFuture - yearBirth;
            Console.WriteLine("My age in 2025 will be: " + ageFuture);

            Console.WriteLine("2:");
            int yearCurrent = 2021;
            int yearPossibleBirth = 1917;
            int agePossible = yearCurrent - yearPossibleBirth;
            Console.WriteLine("If I was born in 1917 I would be: " + agePossible);

            Console.WriteLine("3:");
            DateTime birthday = new DateTime(1995, 10, 21);
            int numberOfDay = (DateTime.Today.Date - birthday.Date).Days;
            int numberOfYear = numberOfDay / 100;
            Console.WriteLine("If there were 100 days in a year, I would be " + numberOfYear + " years old");

            Console.WriteLine("4:");
            decimal rate1 = 2.57m;
            decimal rate2 = 2.78m;
            decimal volumeUSD = 100;
            decimal volumeBYN = volumeUSD * (rate2 - rate1);
            Console.WriteLine("Profit is " + volumeBYN + " BYN");
        }
    }
}
