using System;
class Book
{
    public string Title;
    private int _pages;
    public int Pages
    {
        get { return _pages; }
        set { if (value >= 1) _pages = value; }
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Книга: {Title}, страниц: {_pages}");
    }
}
class Program
{
    static void Main()
    {
        Book b = new Book();
        b.Title = "вайна мир";
        b.Pages = 500;
        b.PrintInfo();
    }
}





class Book
{
    public string Title;
    private int _pages;
    public int Pages
    {
        get { return _pages; }
        set { if (value >= 1) _pages = value; }
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Книга: {Title}, страниц: {_pages}");
    }
}
class Program
{
    static void ChangeBookTitle(Book b)
    {
        b.Title = "Хойка";
    }
    static void ReassignBook(Book b)
    {
        b = new Book();
        b.Title = "Новая книга";
        b.Pages = 100;
    }
    static void Main()
    {
        Book b = new Book();
        b.Title = "ОСД";
        b.Pages = 500;
        ChangeBookTitle(b);
        Console.WriteLine($"После ChangeBookTitle: {b.Title}");
        ReassignBook(b);
        Console.WriteLine($"После ReassignBook: {b.Title}");
    }
}




class Rectangle
{
    private int _width;
    private int _height;
    public int Width
    {
        get { return _width; }
        set { if (value > 0) _width = value; }
    }
    public int Height
    {
        get { return _height; }
        set { if (value > 0) _height = value; }
    }
    public int Area()
    {
        return _width * _height;
    }
}
class Program
{
    static void Main()
    {
        Rectangle r = new Rectangle();
        r.Width = 5;
        r.Height = 10;
        Console.WriteLine($"Площадь: {r.Area()}");
    }
}







class Student
{
    public string Name;
    private int _grade;
    public int Grade
    {
        get { return _grade; }
        set { if (value >= 1 && value <= 5) _grade = value; }
    }
    public void Print()
    {
        Console.WriteLine($"Студент: {Name}, оценка: {_grade}");
    }
}
class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "Пашка";
        s.Grade = 5;
        s.Print();
    }
}





class Stitch
{
    public string name;
    private int _mischiefLevel;
    public int MischiefLevel
    {
        get { return _mischiefLevel; }
        set { if (value >= 1 && value <= 10) _mischiefLevel = value; }
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Стич по кличке {name}, уровень озорства: {_mischiefLevel}");
    }
}
class Program
{
    static void Main()
    {
        Stitch s1 = new Stitch();
        s1.name = "Стич";
        s1.MischiefLevel = 10;
        s1.ShowInfo();
        Stitch s2 = new Stitch();
        s2.name = "Петух";
        s2.MischiefLevel = 7;
        s2.ShowInfo();
    }
}