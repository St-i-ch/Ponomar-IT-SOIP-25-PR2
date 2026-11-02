using System;
using System.Collections.Generic;
class Movie
{
    public string name;
    public int duration;
    public Movie(string name, int duration)
    {
        this.name = name;
        this.duration = duration;
    }
    public override string ToString()
    {
        return $"{name} ({duration} мин)";
    }
}
class Seat
{
    public int number;
    public bool isBusy;
    public Seat(int number)
    {
        this.number = number;
        isBusy = false;
    }
    public bool Reserve()
    {
        if (isBusy)
        {
            Console.WriteLine($"Место {number} уже занято!");
            return false;
        }
        isBusy = true;
        Console.WriteLine($"Место {number} забронировано!");
        return true;
    }
    public void Cancel()
    {
        isBusy = false;
        Console.WriteLine($"Бронь места {number} отменена.");
    }
}
class Customer
{
    public string name;
    public List<Seat> bookings;
    public Customer(string name)
    {
        this.name = name;
        bookings = new List<Seat>();
    }
    public void AddBooking(Seat seat)
    {
        bookings.Add(seat);
    }
    public void ShowBookings()
    {
        Console.WriteLine($"Бронирования {name}:");
        foreach (var s in bookings)
            Console.Write($"{s.number} ");
        Console.WriteLine();
    }
}
class CinemaHall
{
    public List<Seat> seats;
    public CinemaHall(int count)
    {
        seats = new List<Seat>();
        for (int i = 1; i <= count; i++)
            seats.Add(new Seat(i));
    }
    public void ShowHall()
    {
        Console.WriteLine("Схема зала:");
        for (int i = 0; i < seats.Count; i++)
        {
            if (seats[i].isBusy)
                Console.Write("[X] ");
            else
                Console.Write("[ ] ");
        }
        Console.WriteLine();
    }
}
class BookingService
{
    public List<Movie> movies;
    public CinemaHall hall;
    public BookingService(List<Movie> movies, CinemaHall hall)
    {
        this.movies = movies;
        this.hall = hall;
    }
    public void ShowMovies()
    {
        Console.WriteLine("Список фильмов:");
        for (int i = 0; i < movies.Count; i++)
            Console.WriteLine($"{i + 1}. {movies[i]}");
    }
    public Movie SelectMovie()
    {
        ShowMovies();
        Console.Write("Выберите фильм (номер): ");
        int num = int.Parse(Console.ReadLine());
        return movies[num - 1];
    }
    public Seat SelectSeat()
    {
        hall.ShowHall();
        Console.Write("Выберите место (номер): ");
        int num = int.Parse(Console.ReadLine());
        return hall.seats[num - 1];
    }
    public bool Book(Customer customer)
    {
        Movie m = SelectMovie();
        Console.WriteLine($"Выбран фильм: {m.name}");
        Seat seat = SelectSeat();
        if (seat.Reserve())
        {
            customer.AddBooking(seat);
            return true;
        }
        return false;
    }
    public void CancelBooking(Customer customer)
    {
        customer.ShowBookings();
        Console.Write("Введите номер места для отмены: ");
        int num = int.Parse(Console.ReadLine());
        foreach (var s in customer.bookings)
        {
            if (s.number == num)
            {
                s.Cancel();
                customer.bookings.Remove(s);
                return;
            }
        }
        Console.WriteLine("Бронирование не найдено.");
    }
}
class Program
{
    static void Main()
    {
        List<Movie> movies = new List<Movie>();
        movies.Add(new Movie("Дюна", 155));
        movies.Add(new Movie("Интерстеллар", 169));
        movies.Add(new Movie("Начало", 148));
        CinemaHall hall = new CinemaHall(10);
        BookingService service = new BookingService(movies, hall);
        Customer cust = new Customer("Алексей");
        service.Book(cust);
        service.Book(cust);
        service.Book(cust);
        hall.ShowHall();
        cust.ShowBookings();
        service.CancelBooking(cust);
        hall.ShowHall();
        cust.ShowBookings();
    }
}