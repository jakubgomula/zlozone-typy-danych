using System;

public struct Student
{
    public string Imie;
    public string Nazwisko;
    public int NumerIndeksu;
    public string Kierunek;
}

public struct Przedmiot
{
    public string Nazwa;
    public int NumerKatalogowy;
    public string Wydzial;
    public string Opis;
}

public struct NauczycielAkademicki
{
    public string Imie;
    public string Nazwisko;
    public string StopienNaukowy;
    public string Specjalizacja;
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.Imie = "Jan";
        student.Nazwisko = "Kowalski";
        student.NumerIndeksu = 21370;
        student.Kierunek = "Informatyka";

        Console.WriteLine("Dane studenta:");
        Console.WriteLine("Imię: " + student.Imie);
        Console.WriteLine("Nazwisko: " + student.Nazwisko);
        Console.WriteLine("Numer indeksu: " + student.NumerIndeksu);
        Console.WriteLine("Kierunek: " + student.Kierunek);
        Console.WriteLine();

        Przedmiot przedmiot = new Przedmiot();
        przedmiot.Nazwa = "Podstawy programowania";
        przedmiot.NumerKatalogowy = 420;
        przedmiot.Wydzial = "Wydział Informatyki";
        przedmiot.Opis = "Przedmiot dotyczący programowania komputerowego";

        Console.WriteLine("Dane przedmiotu:");
        Console.WriteLine("Nazwa: " + przedmiot.Nazwa);
        Console.WriteLine("Numer katalogowy: " + przedmiot.NumerKatalogowy);
        Console.WriteLine("Wydział: " + przedmiot.Wydzial);
        Console.WriteLine("Opis: " + przedmiot.Opis);
        Console.WriteLine();

        NauczycielAkademicki nauczyciel = new NauczycielAkademicki();
        nauczyciel.Imie = "Paweł";
        nauczyciel.Nazwisko = "Nowak";
        nauczyciel.StopienNaukowy = "dr";
        nauczyciel.Specjalizacja = "Systemy inteligentne";

        Console.WriteLine("Dane nauczyciela akademickiego:");
        Console.WriteLine("Imię: " + nauczyciel.Imie);
        Console.WriteLine("Nazwisko: " + nauczyciel.Nazwisko);
        Console.WriteLine("Stopień naukowy: " + nauczyciel.StopienNaukowy);
        Console.WriteLine("Specjalizacja: " + nauczyciel.Specjalizacja);

        Console.ReadLine();
    }
}
