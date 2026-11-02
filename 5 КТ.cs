using System;
class Box<T>
{
    private T item;
    public void Put(T item)
    {
        this.item = item;
    }
    public T Get()
    {
        return item;
    }
}
class Utils
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
class Pair<T1, T2>
{
    public T1 First;
    public T2 Second;
    public Pair(T1 first, T2 second)
    {
        First = first;
        Second = second;
    }
}
class Program
{
    static void Main()
    {
        Box<int> intBox = new Box<int>();
        intBox.Put(42);
        Console.WriteLine($"Число в коробке: {intBox.Get()}");
        Box<string> strBox = new Box<string>();
        strBox.Put("Hello");
        Console.WriteLine($"Строка в коробке: {strBox.Get()}");
        int a = 5, b = 10;
        Utils.Swap(ref a, ref b);
        Console.WriteLine($"Числа после Swap: {a}, {b}");
        string s1 = "Hello", s2 = "World";
        Utils.Swap(ref s1, ref s2);
        Console.WriteLine($"Строки после Swap: {s1}, {s2}");
        Pair<int, string> pair = new Pair<int, string>(5, "Hello");
        Console.WriteLine($"Первое значение: {pair.First}, Второе значение: {pair.Second}");
    }
}