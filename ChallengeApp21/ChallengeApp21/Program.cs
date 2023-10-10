string myName = "Ewa";
int myAge = 33;
string myGender = "kobieta";

if (myAge < 30 && myGender == "kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (myName == "Ewa" && myAge == 33 && myGender == "kobieta")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (myAge < 18 && myGender == "mężczyzna")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Dane nie pokrywają się z treścią zadania");
}
