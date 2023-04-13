namespace _6_Skip_Take_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Метод Skip() пропускает определенное количество элементов, 
            // а метод Take() извлекает определенное число элементов

            // Извлечем три первых элемента
            int[] numbers = { -3, -2, -1, 0, 1, 2, 3 };
            var result = numbers.Take(3);

            Console.Write("Первых 3 элемента: ");
            foreach (var i in result)
                Console.Write("{0,4}", i);
            Console.WriteLine('\n');

            result = numbers.Skip(3);
            Console.Write("Элементы массива без первых 3 элементов: ");
            foreach (var i in result)
                Console.Write("{0,4}", i);
            Console.WriteLine('\n');

            // Совмещая оба метода, мы можем выбрать заданное количество элементов,
            // начиная с определенного элемента. Например, выберем два элемента,
            // начиная с четвертого (то есть пропустив три элемента).
            result = numbers.Skip(3).Take(2);
            Console.Write("Два элемента, начиная с четвертого: ");
            foreach (var i in result)
                Console.Write("{0,4}", i);
            Console.WriteLine();
            Console.WriteLine();


            // Метод TakeWhile выбирает цепочку элементов, начиная с первого элемента, пока они удовлетворяют определенному условию
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Бримм" };
            foreach (var t in teams.TakeWhile(x => x.StartsWith("Б")))
                Console.WriteLine(t);
            Console.WriteLine('\n');

            // Метод SkipWhile пропускает цепочку элементов, начиная с первого элемента, пока они удовлетворяют определенному условию
            foreach (var t in teams.SkipWhile(x => x.StartsWith("Б")))
                Console.WriteLine(t);
        }
       
    }
}