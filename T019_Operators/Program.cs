int myInt = 5;
int mySecondInt = 10;

Console.WriteLine(myInt);
myInt++;

Console.WriteLine(myInt);

myInt += 7;
myInt -= 8;
Console.WriteLine(myInt);

Console.WriteLine(myInt * mySecondInt);
Console.WriteLine(myInt / mySecondInt);
Console.WriteLine(myInt + mySecondInt);
Console.WriteLine(myInt - mySecondInt);

Console.WriteLine(5 + 5 * 10);
Console.WriteLine((5 + 5) * 10);

Console.WriteLine(Math.Pow(5, 2));
Console.WriteLine(Math.Sqrt(25));

string myString = "test";
Console.WriteLine(myString);

myString += ". Second test.";
Console.WriteLine(myString);

myString = myString + " \"Third\" test.";
Console.WriteLine(myString);

string[] myStringArr = myString.Split(". ");
Console.WriteLine(myStringArr[0]);
Console.WriteLine(myStringArr[1]);
Console.WriteLine(myStringArr[2]);

Console.WriteLine(myInt.Equals(mySecondInt));
Console.WriteLine(myInt.Equals(mySecondInt / 2));

Console.WriteLine(myInt == mySecondInt);
Console.WriteLine(myInt == mySecondInt / 2);
Console.WriteLine(myInt != mySecondInt);
Console.WriteLine(myInt != mySecondInt / 2);

Console.WriteLine(myInt >= mySecondInt);
Console.WriteLine(myInt > mySecondInt);
Console.WriteLine(myInt <= mySecondInt);
Console.WriteLine(myInt < mySecondInt);

Console.WriteLine(5 < 10 && 5 > 10);
Console.WriteLine(5 < 10 || 5 > 10);
