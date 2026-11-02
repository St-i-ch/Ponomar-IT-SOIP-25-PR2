using System;
class Student
{
    private string passportNumber;
    protected int age;
    internal string groupName;
    public string Name;
    protected internal string faculty;
    private string GetPassport()
    {
        return passportNumber;
    }
    protected void SetAge(int a)
    {
        if (a > 0 && a < 120)
            age = a;
    }
    internal void SetGroup(string group)
    {
        groupName = group;
    }
    public void SetName(string name)
    {
        Name = name;
    }
    protected internal void SetFaculty(string fac)
    {
        faculty = fac;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {age}, Группа: {groupName}, Факультет: {faculty}");
    }
}
class AdvancedStudent : Student
{
    public string scholarship;
    public void SetAgeAndScholarship(int a, string sch)
    {
        SetAge(a);
        scholarship = sch;
        faculty = "IT";
    }
    public void ShowAdvanced()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {age}, Стипендия: {scholarship}, Факультет: {faculty}");
    }
}
class StudentManager
{
    public void ManageStudent(Student s)
    {
        s.Name = "Управленец";
        s.groupName = "ИС-21";
        s.faculty = "Информатика";
        s.ShowInfo();
    }
}
class Program
{
    static void Main()
    {
        Student s = new Student();
        s.SetName("Пуп");
        s.SetGroup("XD-67");
        s.ShowInfo();
        AdvancedStudent adv = new AdvancedStudent();
        adv.SetName("Петр");
        adv.SetAgeAndScholarship(20, "5к");
        adv.ShowAdvanced();
        StudentManager mgr = new StudentManager();
        Student s2 = new Student();
        s2.SetName("Сидор");
        mgr.ManageStudent(s2);
    }
}











class Book
{
    public string Title;
    public string Author;
    public int Year;
    public Book()
    {
        Title = "Неизвестно";
        Author = "Неизвестно";
        Year = 0;
    }
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        Year = 2024;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Год: {Year}");
    }
}
class Program
{
    static void Main()
    {
        Book b1 = new Book();
        b1.DisplayInfo();
        Book b2 = new Book("Блич", "Хагаяма", 1995);
        b2.DisplayInfo();
        Book b3 = new Book("сибирь", "пушкин");
        b3.DisplayInfo();
    }
}