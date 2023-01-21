// zmienna z imieniem
// zmienna z płcią
// zmienna z wiekiem
// Kobieta poniżej 30 lat
// Ewa, lat 33
// Niepełnoletni mężczyzna

var Imię = "Ewa";
var Płeć = "Kobieta";
var Wiek = 33;

if (Imię != "Ewa")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (Płeć != "Kobieta")
{
    Console.WriteLine("Niepełnoletni mężczyna");
}
else if (Wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("Ewa, lat 33");
}

