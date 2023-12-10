int a = 50;
int b = 80;
int c = 100;

string s1 = "Hi!";
string s2 = "Hi!";

bool isLessThan = a < b;

bool isLessOrEqualTo = a <= b;

bool isGreaterThan = a > b;

bool isGreaterOrEqual = a >= b;

bool isEqual = a == b;

bool isStringsEquals = string.Equals(s1, s2);

bool isNotEqual = a != b;

bool resultAnd = (a < b) & (b < c);

bool resultOr = (a > c) | (b > c);

if (a != b) // True
{
    // TODO: Do some magic!
}

if (Action1())
{
    System.Console.WriteLine("Magic");
    System.Console.WriteLine("Magic");
    System.Console.WriteLine("Magic");
}
else if (Action2())
{
    System.Console.WriteLine("Else If Magic");
    System.Console.WriteLine("Else If Magic");
}
else if (Action2())
{
    System.Console.WriteLine("Else If Magic");
    System.Console.WriteLine("Else If Magic");
}
else if (Action2())
{
    System.Console.WriteLine("Else If Magic");
    System.Console.WriteLine("Else If Magic");
}
else if (Action2())
{
    System.Console.WriteLine("Else If Magic");
    System.Console.WriteLine("Else If Magic");
}
else if (Action2())
{
    System.Console.WriteLine("Else If Magic");
    System.Console.WriteLine("Else If Magic");
}
else if (Action2())
{
    System.Console.WriteLine("Else If Magic");
    System.Console.WriteLine("Else If Magic");
}
else
{
    System.Console.WriteLine("Else Magic");
    System.Console.WriteLine("Else Magic");
}

int resultStr = Action2() ? 1 : 0;
// block1 - condition
// ?
// block2 - return value
// True
// :
// False

System.Console.WriteLine(resultStr);

bool Action1()
{
    // TODO: Do some magic!
    return true;
}

bool Action2()
{
    // TODO: Do some magic!
    return false;
}

//switch cases     
int number = 0;

switch (number)
{
    case >= 0:
        Console.WriteLine("Positive!");
        break;
    case < 0:
        Console.WriteLine("Negative!");
        break;
}

string str = "TUR";

switch (str)
{
    case "ENG":
        Console.WriteLine("Hello!");
        break;
    case "RUS":
        Console.WriteLine("Привет!");
        break;
    case "TJ":
        Console.WriteLine("Салом!");
        break;

    default:
        Console.WriteLine("Unsupported language!");
        break;

}

switch (str)
{
    case "ENG":
    case "RUS":
    case "TJ":
        Console.WriteLine("Салом!");
        break;

    default:
        Console.WriteLine("Unsupported language!");
        break;
}

Languages lang = Languages.Tajik;

string langStr = GetLanguageString(lang);

string GetLanguageString(Languages languages) => languages switch
{
    Languages.Tajik => "Салом!",
    Languages.English => "Hello!",
    Languages.Russian => "Привет!",
    _ => throw new ArgumentOutOfRangeException(nameof(languages))
};

enum Languages
{
    English,
    Tajik,
    Russian
}