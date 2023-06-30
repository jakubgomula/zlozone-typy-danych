using System;

public enum DniTygodnia
{
    Poniedzialek,
    Wtorek,
    Sroda,
    Czwartek,
    Piatek,
    Sobota,
    Niedziela
}

public enum EtapyPrania
{
    WstepnePlukanie,
    PranieZasadnicze,
    Plukanie,
    Wirowanie
}

public enum Posilki
{
    Sniadanie,
    DrugieSniadanie,
    Obiad,
    Podwieczorek,
    Kolacja
}

public enum BierkiSzachowe
{
    Pionek,
    Wieza,
    Skoczek,
    Goniec,
    Hetman,
    Krol
}

class Program
{
    static void Main(string[] args)
    {
        DniTygodnia dzienTygodnia = DniTygodnia.Piatek;
        Console.WriteLine("Dzisiejszy dzień tygodnia: " + dzienTygodnia);

        EtapyPrania etapPrania = EtapyPrania.PranieZasadnicze;
        Console.WriteLine("Aktualny etap prania: " + etapPrania);

        Posilki posilek = Posilki.Obiad;
        Console.WriteLine("Dzisiejszy posiłek: " + posilek);

        BierkiSzachowe bierkaSzachowa = BierkiSzachowe.Skoczek;
        Console.WriteLine("Wybrana bierka szachowa: " + bierkaSzachowa);

        Console.ReadLine();
    }
}
