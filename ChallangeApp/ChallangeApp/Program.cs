// Dzień 4

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
{
    Console.WriteLine("Mężczyzna");
}

// Dzień 5


string[] daysOfWeek = new string[7];
daysOfWeek[0] = "poniedziałek";
daysOfWeek[1] = "wtorek";
daysOfWeek[2] = "środa";
daysOfWeek[3] = "czwartek";
daysOfWeek[4] = "piątek";
daysOfWeek[5] = "sobota";
daysOfWeek[6] = "niedziela";

string[] daysOfWeek2 = { "monday", "tuesday", "wednesday", "thursday", "firday", "saturday", "sunday" };

foreach (var lolek in daysOfWeek)
{
    Console.WriteLine(lolek);
}

for (var j = 0; j < daysOfWeek2.Length; j = j + 2)
{
    Console.WriteLine(daysOfWeek2[j]);
}

List<string> newDays = new List<string>();
newDays.Add("montag");
newDays.Add("dienstag");
newDays.Add("mittwoch");
newDays.Add("donnerstag");

for (var g = 0; g < newDays.Count; g++)
{
    Console.WriteLine(newDays[g]);
}

if (newDays.Count != 0)
{
    Console.WriteLine("It is working");
}
else
    Console.WriteLine("lipa");






