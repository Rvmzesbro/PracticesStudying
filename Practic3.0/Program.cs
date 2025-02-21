using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic3
{
    internal class Program
    {
        public static Dictionary<string, List<double>> ListSum = new Dictionary<string, List<double>>()
        {

        };

        public static List<double> ListIncome = new List<double>();
        public static List<double> ListProduct = new List<double>();
        public static List<double> ListTransport = new List<double>();
        public static List<double> ListEntertainment = new List<double>();

        public static List<string> category = new List<string>()
            {
                "1. Доход",
                "2. Продукты",
                "3. Транспорт",
                "4. Развлечения",
            };
        public static List<string> NextMonthExpenses = new List<string>()
            {
                "1. Доход",
                "2. Продукты",
                "3. Транспорт",
                "4. Развлечения",
                "5. Посмотреть будущие расходы"
            };
        public static List<string> Statistics = new List<string>()
            {
                "1. Вывести общую сумму расходов",
                "2. Вывести самую затратную категорию",
                "3. Вывести самую частую категорию",
                "4. Расчитать процентное соотношение расходов"
            };
        static void Main(string[] args)
        {

            Console.WriteLine("Добро пожаловать в систему управления финансами!");
            List<string> list = new List<string>()
            {
                "1. Добавить доход/расход",
                "2. Показать отчет",
                "3. Рассчитать баланс",
                "4. Прогноз на следующий месяц",
                "5. Статистика",
                "6. Выход"
            };
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }


            int action = 0;
            while (action < 6 && action >= 0)
            {
                Console.WriteLine("Введите команду: ");
                action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        AddTransaction();
                        break;

                    case 2:
                        PrintFinanceReport();
                        break;

                    case 3:
                        Console.WriteLine($"Текущий баланс: {CalculateBalance()} руб.");
                        break;
                    case 4:
                        PredictNextMonthExpenses();
                        break;
                    case 5:
                        PrintStatistics();
                        break;
                    default:
                        Console.WriteLine("Вы завершили работу");
                        break;
                }
            }
        }
        static void AddTransaction()
        {

           
            foreach (var item in category)
            {
                Console.WriteLine(item);
            }

            int action = int.Parse(Console.ReadLine());
            switch (action)
            {
                case 1:
                    string income = "Доход";
                    Console.WriteLine("Напишите сумму, которую хотите добавить");
                    double sum = double.Parse(Console.ReadLine());
                    if (ListSum.ContainsKey(income))
                    {
                        ListSum[income].Add(sum);
                    }
                    else
                    {
                        ListIncome.Add(sum);
                        ListSum.Add(income, ListIncome);
                    }
                    Console.WriteLine("Запись добавлена.");
                    break;
                case 2:
                    string income1 = "Продукты";
                    Console.WriteLine("Напишите сумму, которую хотите добавить");
                    double sum1 = double.Parse(Console.ReadLine());
                    if (ListSum.ContainsKey(income1))
                    {
                        ListSum[income1].Add(sum1);
                    }
                    else
                    {
                        ListProduct.Add(sum1);
                        ListSum.Add(income1, ListProduct);
                    }
                    Console.WriteLine("Запись добавлена.");
                    break;
                case 3:
                    string income2 = "Транспорт";
                    Console.WriteLine("Напишите сумму, которую хотите добавить");
                    double sum2 = double.Parse(Console.ReadLine());
                    if (ListSum.ContainsKey(income2))
                    {
                        ListSum[income2].Add(sum2);
                    }
                    else
                    {
                        ListTransport.Add(sum2);
                        ListSum.Add(income2, ListTransport);
                    }
                    Console.WriteLine("Запись добавлена.");
                    break;
                case 4:
                    string income3 = "Развлечения";
                    Console.WriteLine("Напишите сумму, которую хотите добавить");
                    double sum3 = double.Parse(Console.ReadLine());
                    if (ListSum.ContainsKey(income3))
                    {
                        ListSum[income3].Add(sum3);
                    }
                    else
                    {
                        ListEntertainment.Add(sum3);
                        ListSum.Add(income3, ListEntertainment);
                    }
                    Console.WriteLine("Запись добавлена.");
                    break;
            }

        }
        static void PrintFinanceReport()
        {
            foreach(var item in ListSum)
            {
                Console.WriteLine(item.Key + " : " + string.Join("; ", item.Value));
            }
        }
        static double CalculateBalance()
        {
            double income = ListSum["Доход"].Sum();
            double expenses = ListSum.Where(p => p.Key != "Доход").Sum(p => p.Value.Sum());
            return income - expenses;
            
        }

        static void GetAverageExpense()
        {
            foreach(var item in NextMonthExpenses)
            {
                Console.WriteLine(item);
            }

            int action = int.Parse(Console.ReadLine());
            double ResultIncome = 0;
            double ResultProduct = 0;
            double ResultTransport = 0;
            double ResultEntertainment = 0;
            switch (action)
            {
                case 1:
                    double SumIncome = ListSum["Доход"].Sum();
                    ResultIncome = SumIncome / ListIncome.Count;
                    Console.WriteLine(ResultIncome);
                    break;
                case 2:
                    double SumProduct = ListSum["Продукты"].Sum();
                    ResultProduct = SumProduct / ListProduct.Count;
                    Console.WriteLine(ResultProduct);
                    break;
                case 3:
                    double SumTransport = ListSum["Транспорт"].Sum();
                    ResultIncome = SumTransport / ListTransport.Count;
                    Console.WriteLine(ResultTransport);
                    break;
                case 4:
                    double SumEntertainment = ListSum["Развлечения"].Sum();
                    ResultIncome = SumEntertainment / ListEntertainment.Count;
                    Console.WriteLine(ResultEntertainment);
                    break;
                case 5:
                    Console.WriteLine($"Будущие расходы: {ResultProduct + ResultTransport + ResultEntertainment} руб.");
                    break;
            }
        }

        static void PredictNextMonthExpenses()
        {
            GetAverageExpense();
        }
        static void PrintStatistics()
        {
            foreach(var item in Statistics)
            {
                Console.WriteLine(item);
            }
            
            int action = int.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    double expenses = ListSum.Where(p => p.Key != "Доход").Sum(p => p.Value.Sum());
                    Console.WriteLine(expenses);
                    break;
                case 2:

                    break;
            }
        }
    }
}
