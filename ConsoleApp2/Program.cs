//Assignment Operators
int var0 = 30;
var0 += 7;
Console.WriteLine(var0);

var0 -= 17;
Console.WriteLine(var0);

var0 *= 3;
Console.WriteLine(var0);

var0 /= 6;
Console.WriteLine(var0);

var0 %= 4;
Console.WriteLine(var0);

bool var1 = true;
var1 &= false;
Console.WriteLine(var1);

var1 |= true;
Console.WriteLine(var1);

var1 ^= false;
Console.WriteLine(var1);

Console.WriteLine('\n');
//Comparison Operators

int x = 6;
int y = 7;

Console.WriteLine(x == y);
Console.WriteLine(y != x);
Console.WriteLine(x < y);
Console.WriteLine(y > x);
Console.WriteLine(x >= y);
Console.WriteLine(y <= x);

Console.WriteLine('\n');

//Logical Operators

int a = 65;
int b = 70;

Console.WriteLine(a < 400 && b > 6);
Console.WriteLine(a < 5 || b > 6);
Console.WriteLine(!(a == b));

Console.WriteLine('\n');

//Math Class

int c=Math.Max(a, b);
Console.WriteLine(c);

c= Math.Min(a, b);
Console.WriteLine(c);

double s = Math.Sqrt(81);
Console.WriteLine(s);

Console.WriteLine("\n");

int neg = -899;
int pos=Math.Abs(neg);
Console.WriteLine(pos);

float unr = 4.99F;
double r = Math.Round(unr);
Console.WriteLine(r);


//String Class
string sentence = "I own a parrot named Ricco";
Console.WriteLine("This string: " + sentence + " has the length of: " + sentence.Length + " characters");
Console.WriteLine("The sentence written in lower case characters: " + sentence.ToLower());
Console.WriteLine("The sentence written in upper case characters: " + sentence.ToUpper());
Console.WriteLine('\n');
//String Concatenation

string firstWord = "Sammy";
string secondWord = "Thompson";
string concatenated1 = firstWord +' '+ secondWord;
Console.WriteLine(concatenated1);

string concatenated2 = string.Concat(firstWord,' ', secondWord);
Console.WriteLine(concatenated2);



