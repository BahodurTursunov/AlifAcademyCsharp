using System;
using System.Text;

string str = "Hi!";
str = "Hello" + ", World!";

StringBuilder stringBuilder = new();
stringBuilder.Append("Hello");
stringBuilder.Append(",");
stringBuilder.Append(" World!"); // , World!
stringBuilder.Remove(0, 5);

string s = stringBuilder.ToString();

// operators.

// = - assigment.
float floatNumber = 3.14;
float floatNumber2 = floatNumber % 5;

// unary operators.
int negativeNumber = -10;
int positiveNumber = +negativeNumber; // +10
negativeNumber = -positiveNumber; // -10

int i = 0;
i++; // 1
i--; // 0

int pref_i = 3; // 4
int pref_result = ++pref_i; // 4

int pref_dec_i = 7; // 6
int pref_dec_result = --pref_dec_i; // 6


bool isTrue = true;
bool isFalse = !isTrue; // false
isTrue = !isFalse; // true

int number2 = 5;
int result = ~number2; // -6
// 00000101 == 5
// 11111010 == -6

// logical oper.
bool condition1 = false;
bool condition2 = true;

// logical AND.
bool result = condition1 && condition2;

// logical OR.
bool orResult = condition1 || condition2;

// logical exceptional OR. ^
bool exResult = condition1 ^ condition2;

// const.
int number = 10;
number = 20;

const float PI = 3.14;
// PI = 5; // Error!

// Enumerations Flags
Permission guestUserPermission = Permission.Read;
Permission adminUserPermission = Permission.Write | Permission.Read;

bool hasRWPermission = adminUserPermission.HasFlag(Permission.Write);

[Flags]
enum Permission
{
    Read,
    Write
};