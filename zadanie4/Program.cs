using System;

public enum Plec
{
    Mezczyzna,
    Kobieta
}

public struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public double Ocena;
    public Plec Plec;

    public Student(string nazwisko, int nrAlbumu, double ocena, Plec plec)
    {
        Nazwisko = nazwisko;
        NrAlbumu = nrAlbumu;
        Ocena = Math.Max(2.0, Math.Min(5.0, ocena)); // Ograniczenie oceny do przedziału [2.0, 5.0]
        Plec = plec;
    }

    public void WyswietlInformacje()
    {
        Console.Write($"{Nazwisko} (Nr albumu: {NrAlbumu}), ");
        Console.Write($"Ocena: {Ocena}, ");
        Console.WriteLine($"Płeć: {Plec}");
    }
}

public class Program
{
    public static void Main()
    {
        Student[] grupa = new Student[5];

        // Wypełniamy tablicę informacjami o studentach
        WypelnijStudentow(grupa);

        // Wyświetlamy informacje o studentach
        Console.WriteLine("Studenci:");
        foreach (var student in grupa)
        {
            student.WyswietlInformacje();
        }

        // Obliczamy i wyświetlamy średnią ocen
        double sredniaOcen = ObliczSredniaOcen(grupa);
        Console.WriteLine($"Średnia ocen: {sredniaOcen}");
    }

    public static void WypelnijStudentow(Student[] grupa)
    {
        grupa[0] = new Student("Kowalski", 123456, 4.5, Plec.Mezczyzna);
        grupa[1] = new Student("Nowak", 234567, 3.0, Plec.Mezczyzna);
        grupa[2] = new Student("Wójcik", 345678, 2.5, Plec.Kobieta);
        grupa[3] = new Student("Lewandowska", 456789, 5.5, Plec.Kobieta); // Ocena zostanie ograniczona do 5.0
        grupa[4] = new Student("Jankowski", 567890, 1.0, Plec.Mezczyzna); // Ocena zostanie ograniczona do 2.0
    }

    public static double ObliczSredniaOcen(Student[] grupa)
    {
        double sumaOcen = 0;

        foreach (var student in grupa)
        {
            sumaOcen += student.Ocena;
        }

        return sumaOcen / grupa.Length;
    }
}
