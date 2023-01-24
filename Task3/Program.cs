class Program
{

    //Time complexity - O(2^n), так как каждое действие вызывает еще 2 вызова функции, т.е. растет экспоненциально
    //Space complexity - O(n), так как глубина дерева рекурсии равна n
    private static int RecursiveFibonacci(int n)
    {
        if (n <= 2) return 1;
        return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
    }
    
    //Time complexity - O(n) итерируем n раз
    //Space compelixy - O(1) константное и не зависит от кол-ва входных данных
    private static int IterativeFibonacci(int n)
    {
        if (n <= 2) return 1;   
        int firstNum = 1, secondNum = 1, next;
        for (int i = 1; i < n; i++)
        {
            next = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = next;
        }

        return firstNum;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine(IterativeFibonacci(14));
        Console.WriteLine(RecursiveFibonacci(14));
    }
}