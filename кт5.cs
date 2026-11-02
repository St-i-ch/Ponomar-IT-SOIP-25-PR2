using System;
//объясняю Я не ии, ни кто либо другой, что бы не было каких либо вопросов
class Box<T> /*Box просто название а Т это пустышка которой мы даем какой то тип*/
{
    T item;
    public void Put(T item) /*тут мы что получаем на хранение типа Т*/
    {
        this.item = item;
    }
    public T Get()/* возвращает получает данные из item*/
    {
        return item;
    }
}
class Utils
{
    public static void Swap<T>(ref T a, ref T b)/* ну тут получаеться так что а и б присваевается значение Т, буквально свапает значения. ref это типо передача по ссылке*/
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
class Pair<T1, T2> 
{
    public T1 first;
    public T2 second;
    public Pair(T1 first, T2 second)
    {
        this.first = first;
        this.second = second;
    }
}
class Program
{
    static void Main()
    {
        Box<int> box1 = new Box<int>();
        box1.Put(1488);
        Console.WriteLine("Число в коробке: " + box1.Get());
        Box<string> box2 = new Box<string>();
        box2.Put("тута из первого задания стринг");
        Console.WriteLine("Строка в коробке: " + box2.Get());
        int x = 5, y = 10;
        Utils.Swap(ref x, ref y);
        Console.WriteLine("Числа после Swap: " + x + ", " + y);
        string s1 = "туда", s2 = "сюда";
        Utils.Swap(ref s1, ref s2);
        Console.WriteLine("Строки после Swap: " + s1 + ", " + s2);
        Pair<int, string> pair = new Pair<int, string>(5, "ну тут стринг а там инт, вот и два типа");
        Console.WriteLine("Первое значение: " + pair.first + ", Второе значение: " + pair.second);
    }
}