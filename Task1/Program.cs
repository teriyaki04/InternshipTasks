class Program
{
    public static void Main(string[] args)
    {
        
        var input = Console.ReadLine().Split(' '); // помещаем в массив строк введенную строку с разделителем пробел, т.е. его не учитываем.

        var result = input
            .GroupBy(x => x.Length) // группируем массив по длине строки
            .OrderBy(x => x.Key)    // ключ в данном случае это длина строки, сортируем(по возрастанию) по ней так как при группировании все будет вперемешку
            .Select(x => new
                {
                    // собственно происходит выборка данных, где Length - длина строки которую мы отсортировали до этого
                    // а Words - слова с такой длинной строки.
                    Length = x.Key, 
                    Words = x.Distinct().ToList()
                }
            ); 

        //Вывод
        foreach (var item in result)
        {
            Console.WriteLine($"Words of length: {item.Length}, Count:{item.Words.Count}");
            Console.WriteLine($"{string.Join("\n",item.Words)}");
        }


    }
}