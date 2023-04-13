namespace _4_Sets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ имеет несколько методов для работы с множествами: разность, объединение и пересечение

            // С помощью метода Except можно получить разность двух множеств
            string[] soft = { "Microsoft", "Google", "Apple" };
            string[] hard = { "Apple", "IBM", "Samsung" };

            Console.WriteLine("Исходные множества");

            foreach (var s in soft)
                Console.Write(s + " ");
            Console.WriteLine();

            foreach (var s in hard)
                Console.Write(s + " ");

            // разность множеств
            var result = soft.Except(hard);
            Console.WriteLine("\n\nPазность множеств");
            foreach (var s in result)
                Console.Write(s + " ");

            // Для получения пересечения множеств, то есть общих для обоих наборов элементов, применяется метод Intersect
            // пересечение множеств
            result = soft.Intersect(hard);
            Console.WriteLine("\n\nПересечение множеств");
            foreach (var s in result)
                Console.Write(s + " ");


            // Для объединения двух множеств используется метод Union. 
            // Его результатом является новый набор, в котором имеются элементы, как из одного, так и из второго множества. 
            // Повторяющиеся элементы добавляются в результат только один раз
            // объединение множеств
            result = soft.Union(hard);
            Console.WriteLine("\n\nОбъединение множеств");
            foreach (var s in result)
                Console.Write(s + " ");


            // Если необходимо простое объединение двух наборов, то можно использовать метод Concat
            result = soft.Concat(hard);
            Console.WriteLine("\n\nКонкатенация множеств");
            foreach (var s in result)
                Console.Write(s + " ");
            

            // Для удаления дубликатов в наборе используется метод Distinct
            result = result.Distinct();
            Console.WriteLine("\n\nУдаление дубликатов");
            foreach (var s in result)
                Console.Write(s + " ");
            Console.WriteLine("\n");
        }
    }
}