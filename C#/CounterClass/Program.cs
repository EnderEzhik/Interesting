class Counted
{
    public static int TotalCount { get; private set; } = 0;
    public readonly int CurrentCount;

    public Counted()
    {
        TotalCount++;
        CurrentCount = TotalCount;
    }

    public static void PrintTotalCount()
    {
        Console.WriteLine($"Всего создано экземпляров класса: {TotalCount}");
    }

    public void PrintCurrentCount()
    {
        Console.WriteLine($"Номер текущего экземпляра класса: {CurrentCount}");
    }
}

class Program
{
    public static void Main()
    {
        var delimiter = new String('-', 25);
      
        Counted.PrintTotalCount();
        Console.WriteLine(delimiter);

        var example = new Counted();
        example.PrintCurrentCount();
        Console.WriteLine("Общее количество классов напрямую через переменную: " + Counted.TotalCount);
        Console.WriteLine(delimiter);

        _ = new Counted();
        _ = new Counted();
        Counted.PrintTotalCount();
        example.PrintCurrentCount();
    }
}
