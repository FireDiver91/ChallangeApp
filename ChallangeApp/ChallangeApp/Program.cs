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



var number = Console.ReadLine();
char[] letters = number.ToString().ToArray();
List<char> chars= new List<char>();
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
















