int liczba = 955019;
Console.WriteLine("Liczba którą podałeś/aś to: " + liczba);
string LiczbaNaStringa = liczba.ToString();
char[] znaki = LiczbaNaStringa.ToCharArray();

int zlicz0 = 0;
int zlicz1 = 0;
int zlicz2 = 0;
int zlicz3 = 0;
int zlicz4 = 0;
int zlicz5 = 0;
int zlicz6 = 0;
int zlicz7 = 0;
int zlicz8 = 0;
int zlicz9 = 0;

foreach (char ilosc in znaki)
{
    if (ilosc == '0')
    {
        zlicz0++;
    }
    else if (ilosc == '1')
    {
        zlicz1++;
    }
    else if (ilosc == '2')
    {
        zlicz2++;
    }
    else if (ilosc == '3')
    {
        zlicz3++;
    }
    else if (ilosc == '4')
    {
        zlicz4++;
    }
    else if (ilosc == '5')
    {
        zlicz5++;
    }
    else if (ilosc == '6')
    {
        zlicz6++;
    }
    else if (ilosc == '7')
    {
        zlicz7++;
    }
    else if (ilosc == '8')
    {
        zlicz8++;
    }
    else if (ilosc == '9')
    {
        zlicz9++;
    }
}
Console.WriteLine("Zer mamy: " + zlicz0);
Console.WriteLine("Jedynek mamy: " + zlicz1);
Console.WriteLine("Dwojek mamy: " + zlicz2);
Console.WriteLine("Trojek mamy: " + zlicz3);
Console.WriteLine("Czworek mamy: " + zlicz4);
Console.WriteLine("Piatek mamy: " + zlicz5);
Console.WriteLine("Szostek mamy: " + zlicz6);
Console.WriteLine("Siodemek mamy: " + zlicz7);
Console.WriteLine("Osemek mamy: " + zlicz8);
Console.WriteLine("Dziewiatek mamy: " + zlicz9);