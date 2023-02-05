// dzień 5 - zdanie domowe.

/*var number = console.readline();
char[] letters = number.toarray();

list<char> digits = new list<char>();
digits.add('0');
digits.add('1');
digits.add('2');
digits.add('3');
digits.add('4');
digits.add('5');
digits.add('6');
digits.add('7');
digits.add('8');
digits.add('9');

foreach (char c in digits)
{
var count = 0;
foreach (char l in letters)
{
if (c==l)
{
count++; 
        }  
    }
console.writeline("ilość" + (c) + "=>" + (count));
}*/



/*var number = Console.ReadLine();
char[] letters = number.ToString().ToArray();
List<char> cyfry = new List<char>();
cyfry.Add('0');
cyfry.Add('1');
cyfry.Add('2');
cyfry.Add('3');
cyfry.Add('4');
cyfry.Add('5');
cyfry.Add('6');
cyfry.Add('7');
cyfry.Add('8');
cyfry.Add('9');

foreach (var c in cyfry)
{ 
    var licz = 0;
    foreach (var l in letters)
    {
        if (l == c)
        {
            licz++;

        }
    }
    Console.WriteLine($"{c} => {licz}");
}
*/




/* var number = Console.ReadLine();
char[] letters = number.ToString().ToArray();
List<char> chars = new List<char>();
chars.Add('0');
chars.Add('1');
chars.Add('2');
chars.Add('3');
chars.Add('4');
chars.Add('5');
chars.Add('6');
chars.Add('7');
chars.Add('8');
chars.Add('9');

for (var i = 0; i < chars.Count; i++)
{
    var count = 0;

    foreach (var l in letters)
    {
        if (chars[i] == l)
        {
            count++;
        }
    }
    Console.WriteLine($"{i} ==> {count}");
}

List<string> Names = new List<string>() { "Adam", "Jan" };
List<int> Numbers = new List<int>() { 1, 2, 3 };

foreach (var n in Names)
{
    Console.WriteLine(n);
    foreach (var i in Numbers)
    {
        Console.WriteLine(i);

    }
}*/



/*User user1 = new("Michał", "asdfa123");
User user2 = new("Maka", "Klimek");
User user3 = new("Hela", "34412*123");


var name1 = user1.Login;
var password1 = user1.Password;

user1.AddSocre(10);
user1.AddSocre(4);
var result1 = user1.Result;

Console.WriteLine(name1);
Console.WriteLine(password1);
Console.WriteLine(result1);
class User
{
    private List<int> score = new();
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }
    public string Login { get; private set; }
    public string Password { get; private set; }
    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
    public void AddSocre(int number)
    {
        this.score.Add(number);
    }

}*/


using ChallangeApp;

/*User user1 = new("Michał", " Klimek");
var n = user1.Name;
var s = user1.Surename;
Console.WriteLine(n + s);
user1.AddScore(3);
user1.AddScore(3);
user1.AddScore(660);
var w = user1.Score;
Console.WriteLine(w);
*/

Employee worker1 = new("Jan", "Kowalski", "25");
worker1.AddGrades(4);
worker1.AddGrades(5);
worker1.AddGrades(4);
worker1.AddGrades(8);
worker1.AddGrades(10);
var sum1 = worker1.Count;

Employee worker2 = new("Marcin", "Kwiatkowski", "45");
worker2.AddGrades(4);
worker2.AddGrades(1);
worker2.AddGrades(5);
worker2.AddGrades(10);
worker2.AddGrades(9);
var sum2 = worker2.Count;

Employee worker666 = new("Edi", "IronMaiden", "48");
worker666.AddGrades(10);
worker666.AddGrades(10);
worker666.AddGrades(10);
worker666.AddGrades(10);
worker666.AddGrades(626);
var sum3 = worker666.Count;

List<Employee> list = new List<Employee>() { worker1, worker2, worker666 };

var maxResult = -1;
Employee emploWithmaxGrades = null;

foreach (var workers in list)
{
    if (workers.Count > maxResult)
    {
        maxResult = workers.Count;
        emploWithmaxGrades = workers;
    }
}
Console.WriteLine("The worker of the month is ");
Console.WriteLine(emploWithmaxGrades.Name);
Console.WriteLine(emploWithmaxGrades.Surename);
Console.WriteLine($"Age {emploWithmaxGrades.Age}");
Console.WriteLine($"With the sum of ponints = {emploWithmaxGrades.Count} pkt");
Console.WriteLine("Congratulation! ");





















