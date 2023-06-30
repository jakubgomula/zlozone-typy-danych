using System;

public enum KlasaRzadkosci
{
    Powszechny,
    Rzadki,
    Unikalny,
    Epicki
}

public enum TypPrzedmiotu
{
    Bron,
    Zbroja,
    Amulet,
    Pierścień,
    Hełm,
    Tarcza,
    Buty
}

public struct Przedmiot
{
    public double Waga;
    public int Wartosc;
    public KlasaRzadkosci Rzadkosc;
    public TypPrzedmiotu Typ;
    public string NazwaWlasna;

    public Przedmiot(double waga, int wartosc, KlasaRzadkosci rzadkosc, TypPrzedmiotu typ, string nazwaWlasna)
    {
        Waga = waga;
        Wartosc = wartosc;
        Rzadkosc = rzadkosc;
        Typ = typ;
        NazwaWlasna = nazwaWlasna;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Nazwa: {NazwaWlasna}");
        Console.WriteLine($"Typ: {Typ}");
        Console.WriteLine($"Rzadkosc: {Rzadkosc}");
        Console.WriteLine($"Waga: {Waga}");
        Console.WriteLine($"Wartosc: {Wartosc} sztuk złota");
    }
}

public class Program
{
    public static void Main()
    {
        Przedmiot[] przedmioty = new Przedmiot[5];

        // Wypełniamy tablicę przedmiotami
        WypelnijPrzedmioty(przedmioty);

        // Wyświetlamy informacje o wszystkich przedmiotach
        Console.WriteLine("Przedmioty:");
        foreach (var przedmiot in przedmioty)
        {
            przedmiot.WyswietlInformacje();
            Console.WriteLine("----------------------------");
        }

        // Losowo wybieramy przedmiot z uwzględnieniem rzadkości
        Console.WriteLine("Losowo wybrany przedmiot:");
        Przedmiot losowyPrzedmiot = WylosujPrzedmiot(przedmioty);
        losowyPrzedmiot.WyswietlInformacje();
    }

    public static void WypelnijPrzedmioty(Przedmiot[] przedmioty)
    {
        przedmioty[0] = new Przedmiot(2.5, 100, KlasaRzadkosci.Powszechny, TypPrzedmiotu.Bron, "Miecz");
        przedmioty[1] = new Przedmiot(1.8, 150, KlasaRzadkosci.Rzadki, TypPrzedmiotu.Zbroja, "Zbroja płytowa");
        przedmioty[2] = new Przedmiot(0.3, 50, KlasaRzadkosci.Unikalny, TypPrzedmiotu.Amulet, "Amulet mocy");
        przedmioty[3] = new Przedmiot(0.1, 200, KlasaRzadkosci.Epicki, TypPrzedmiotu.Pierścień, "Pierścień nieśmiertelności");
        przedmioty[4] = new Przedmiot(0.8, 80, KlasaRzadkosci.Powszechny, TypPrzedmiotu.Hełm, "Hełm rycerski");
    }

    public static Przedmiot WylosujPrzedmiot(Przedmiot[] przedmioty)
    {
        Random rand = new Random();
        int sumaPrawdopodobienstw = 0;

        foreach (var przedmiot in przedmioty)
        {
            sumaPrawdopodobienstw += (int)przedmiot.Rzadkosc + 1;
        }

        int losowaWartosc = rand.Next(1, sumaPrawdopodobienstw + 1);
        int aktualnaSuma = 0;

        foreach (var przedmiot in przedmioty)
        {
            aktualnaSuma += (int)przedmiot.Rzadkosc + 1;
            if (losowaWartosc <= aktualnaSuma)
            {
                return przedmiot;
            }
        }

        // W razie jakiegoś problemu zwracamy pierwszy przedmiot z tablicy
        return przedmioty[0];
    }
}
