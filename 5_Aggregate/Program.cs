namespace _5_Aggregate
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // К агрегатным операциям относят различные операции над выборкой, например, 
            // получение числа элементов, получение минимального, максимального и среднего значения в выборке, 
            // а также суммирование значений

            // Метод Aggregate выполняет общую агрегацию элементов коллекции в зависимости от указанного выражения
            int[] numbers = { 1, 2, 3, 4, 5 };

            int query = numbers.Aggregate((x, y) => x - y);
            Console.WriteLine("Res of Aggregate((x, y) => x - y): " + query);
            Console.WriteLine();
            // Переменная query будет представлять результат агрегации массива. 
            // В качестве условия агрегации используется выражение (x,y)=> x - y, 
            // то есть вначале из первого элемента вычитается второй, 
            // потом из получившегося значения вычитается третий и так далее.
            query = numbers.Aggregate((x, y) => x * y);
            Console.WriteLine("Res of Aggregate((x, y) => x * y): " + query);
            Console.WriteLine();

            // Для получения числа элементов в выборке используется метод Count()
            int[] numbers2 = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            int size = (from i in numbers2 where i % 2 == 0 && i > 10 select i).Count();
            Console.WriteLine("Число элементов в выборке: " + size);
            Console.WriteLine();

            // Метод Count() в одной из версий также может принимать лямбда-выражение, 
            // которое устанавливает условие выборки. 
            size = numbers2.Count(i => i % 2 == 0 && i > 10);
            Console.WriteLine("Число элементов в выборке: " + size);
            Console.WriteLine();

            numbers = new int[] { 2, 2, 3, 5, 5 };
            int unique = numbers.Distinct().Count();
            Console.WriteLine("There are {0} unique numbers\n", unique);

            List<User> users = new List<User>()
            {
                new User { Name = "Tom", Age = 23 },
                new User { Name = "Sam", Age = 43 },
                new User { Name = "Bill", Age = 35 }
            };
            // Для получения суммы значений применяется метод Sum
            int sum = numbers.Sum();
            Console.WriteLine("Сумма элементов массива: " + sum);
            Console.WriteLine();
            sum = users.Sum(n => n.Age);
            Console.WriteLine("Сумма элементов возрастов: " + sum);
            Console.WriteLine();

            string[] words = { "cherry", "apple", "blueberry" };
            int totalChars = words.Sum(w => w.Length);
            Console.WriteLine("Всего символов в строке: " + totalChars);
            Console.WriteLine();

            // Для нахождения минимального значения применяется метод Min(), 
            // для получения максимального - метод Max(), 
            // а для нахождения среднего значения - метод Average()
            int min1 = numbers2.Min();
            Console.WriteLine("Минимальный элемент массива: " + min1);
            Console.WriteLine();

            int min2 = users.Min(n => n.Age); // минимальный возраст
            Console.WriteLine("Минимальный возраст: " + min2);
            Console.WriteLine();

            int max1 = numbers2.Max();
            Console.WriteLine("Максимальный элемент массива: " + max1);
            Console.WriteLine();

            int max2 = users.Max(n => n.Age); // максимальный возраст
            Console.WriteLine("Максимальный возраст: " + max2);
            Console.WriteLine();

            double avr1 = numbers2.Average();
            Console.WriteLine("Среднее арифметическое массива: " + avr1);
            Console.WriteLine();

            double avr2 = users.Average(n => n.Age); //средний возраст
            Console.WriteLine("Средний возраст: " + avr2.ToString("F2"));
            Console.WriteLine('\n');
        }
    }
}