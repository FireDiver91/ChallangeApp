// zmienna z imieniem
// zmienna z płcią
// zmienna z wiekiem
// Kobieta poniżej 30 lat
// Ewa, lat 33
// Niepełnoletni mężczyzna


var name = "Zbigniew";
var sex = "Male";
var age = 115;

if (sex == "Female" && name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (sex == "Famale" && name != "Ewa" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (sex != "Female" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");

}
else
    Console.WriteLine("Mężczyzna");






