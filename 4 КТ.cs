using System;
struct Point
{
    public double X;
    public double Y;
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}
class Program
{
    static void Main()
    {
        Point p1 = new Point(3, 4);
        Point p2 = new Point(7, 1);
        Console.WriteLine($"Точка 1: ({p1.X}, {p1.Y})");
        Console.WriteLine($"Точка 2: ({p2.X}, {p2.Y})");
        double dist = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        Console.WriteLine($"Расстояние: {dist:F2}");
    }
}










struct Rectangle
{
    public double Width;
    public double Height;
    public Rectangle(double w, double h)
    {
        Width = w;
        Height = h;
    }
    public double Area()
    {
        return Width * Height;
    }
    public double Perimeter()
    {
        return 2 * (Width + Height);
    }
}
class Program
{
    static void Main()
    {
        Rectangle r = new Rectangle(5, 3);
        Console.WriteLine($"Площадь: {r.Area()}");
        Console.WriteLine($"Периметр: {r.Perimeter()}");
    }
}









struct Book
{
    public string Title;
    public string Author;
    public int Year;
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"{Title} — {Author} ({Year} год издания)");
    }
}
class Program
{
    static void Main()
    {
        Book b = new Book("Война и мир", "Толстой", 1869);
        b.ShowInfo();
    }
}







struct ComplexNumber
{
    public double Real;
    public double Imag;
    public ComplexNumber(double real, double imag)
    {
        Real = real;
        Imag = imag;
    }
    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber(Real + other.Real, Imag + other.Imag);
    }
    public ComplexNumber Subtract(ComplexNumber other)
    {
        return new ComplexNumber(Real - other.Real, Imag - other.Imag);
    }
    public ComplexNumber Multiply(ComplexNumber other)
    {
        double r = Real * other.Real - Imag * other.Imag;
        double i = Real * other.Imag + Imag * other.Real;
        return new ComplexNumber(r, i);
    }
    public void Show()
    {
        Console.WriteLine($"{Real} + {Imag}i");
    }
}
class Program
{
    static void Main()
    {
        ComplexNumber c1 = new ComplexNumber(3, 2);
        ComplexNumber c2 = new ComplexNumber(1, 4);
        Console.Write("c1: "); c1.Show();
        Console.Write("c2: "); c2.Show();
        Console.Write("Сложение: "); c1.Add(c2).Show();
        Console.Write("Вычитание: "); c1.Subtract(c2).Show();
        Console.Write("Умножение: "); c1.Multiply(c2).Show();
    }
}







struct Color
{
    public int R;
    public int G;
    public int B;
    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }
    public string ToHex()
    {
        return $"#{R:X2}{G:X2}{B:X2}";
    }
}
class Program
{
    static void Main()
    {
        Color c = new Color(255, 128, 0);
        Console.WriteLine(c.ToHex());
    }
}






struct SimpleDate
{
    public int Day;
    public int Month;
    public int Year;
    public SimpleDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }
    public bool IsLeapYear()
    {
        return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
    }
}
class Program
{
    static void Main()
    {
        SimpleDate d = new SimpleDate(15, 3, 2024);
        Console.WriteLine($"{d.Day}.{d.Month}.{d.Year} — високосный: {d.IsLeapYear()}");
    }
}








struct Vector2D
{
    public double X;
    public double Y;
    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }
    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
    public Vector2D Normalize()
    {
        double len = Length();
        return new Vector2D(X / len, Y / len);
    }
    public double Dot(Vector2D other)
    {
        return X * other.X + Y * other.Y;
    }
}
class Program
{
    static void Main()
    {
        Vector2D v1 = new Vector2D(3, 4);
        Vector2D v2 = new Vector2D(1, 2);
        Console.WriteLine($"Длина v1: {v1.Length()}");
        Vector2D n = v1.Normalize();
        Console.WriteLine($"Нормализованный: ({n.X:F3}, {n.Y:F3})");
        Console.WriteLine($"Скалярное произведение: {v1.Dot(v2)}");
    }
}






struct Money
{
    public int Rubles;
    public int Kopecks;
    public Money(int rubles, int kopecks)
    {
        Rubles = rubles;
        Kopecks = kopecks;
    }
    private int ToKopecks()
    {
        return Rubles * 100 + Kopecks;
    }
    private Money FromKopecks(int total)
    {
        return new Money(total / 100, total % 100);
    }
    public Money Add(Money other)
    {
        return FromKopecks(ToKopecks() + other.ToKopecks());
    }
    public Money Subtract(Money other)
    {
        return FromKopecks(ToKopecks() - other.ToKopecks());
    }
    public bool IsGreater(Money other)
    {
        return ToKopecks() > other.ToKopecks();
    }
    public void Show()
    {
        Console.WriteLine($"{Rubles} руб. {Kopecks} коп.");
    }
}
class Program
{
    static void Main()
    {
        Money m1 = new Money(100, 50);
        Money m2 = new Money(200, 75);
        Console.Write("m1: "); m1.Show();
        Console.Write("m2: "); m2.Show();
        Console.Write("Сумма: "); m1.Add(m2).Show();
        Console.Write("Разность: "); m2.Subtract(m1).Show();
        Console.WriteLine($"m2 > m1: {m2.IsGreater(m1)}");
    }
}








struct Point
{
    public double X;
    public double Y;
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public double DistanceTo(Point other)
    {
        return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
    }
}
struct Triangle
{
    public Point A;
    public Point B;
    public Point C;
    public Triangle(Point a, Point b, Point c)
    {
        A = a;
        B = b;
        C = c;
    }
    public double SideAB()
    {
        return A.DistanceTo(B);
    }
    public double SideBC()
    {
        return B.DistanceTo(C);
    }
    public double SideAC()
    {
        return A.DistanceTo(C);
    }
    public double Perimeter()
    {
        return SideAB() + SideBC() + SideAC();
    }
    public double Area()
    {
        double a = SideAB(), b = SideBC(), c = SideAC();
        double p = Perimeter() / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}
class Program
{
    static void Main()
    {
        Triangle t = new Triangle(new Point(0, 0), new Point(4, 0), new Point(0, 3));
        Console.WriteLine($"Стороны: {t.SideAB():F2}, {t.SideBC():F2}, {t.SideAC():F2}");
        Console.WriteLine($"Периметр: {t.Perimeter():F2}");
        Console.WriteLine($"Площадь: {t.Area():F2}");
    }
}








struct Point3D
{
    public double X;
    public double Y;
    public double Z;
    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public double DistanceTo(Point3D other)
    {
        return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2) + Math.Pow(other.Z - Z, 2));
    }
}
class Program
{
    static void Main()
    {
        Point3D p1 = new Point3D(1, 2, 3);
        Point3D p2 = new Point3D(4, 6, 3);
        Console.WriteLine($"Расстояние: {p1.DistanceTo(p2):F2}");
    }
}








struct ChessPiece
{
    public string Name;
    public string Position;
    public ChessPiece(string name, string position)
    {
        Name = name;
        Position = position;
    }
    public void Move(string newPosition)
    {
        Console.WriteLine($"{Name} перемещается с {Position} на {newPosition}");
        Position = newPosition;
    }
}
class Program
{
    static void Main()
    {
        ChessPiece piece = new ChessPiece("Конь", "E4");
        piece.Move("F6");
        Console.WriteLine($"Текущая позиция: {piece.Position}");
    }
}






struct GeoPoint
{
    public double Latitude;
    public double Longitude;
    public GeoPoint(double lat, double lon)
    {
        Latitude = lat;
        Longitude = lon;
    }
    public double DistanceTo(GeoPoint other)
    {
        double R = 6371;
        double lat1 = Latitude * Math.PI / 180;
        double lat2 = other.Latitude * Math.PI / 180;
        double dLat = (other.Latitude - Latitude) * Math.PI / 180;
        double dLon = (other.Longitude - Longitude) * Math.PI / 180;
        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                   Math.Cos(lat1) * Math.Cos(lat2) *
                   Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        return R * c;
    }
}
class Program
{
    static void Main()
    {
        GeoPoint p1 = new GeoPoint(55.7558, 37.6173);
        GeoPoint p2 = new GeoPoint(59.9343, 30.3351);
        Console.WriteLine($"Расстояние: {p1.DistanceTo(p2):F2} км");
    }
}