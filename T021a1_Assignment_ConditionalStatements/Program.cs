string myFirstValue = "some words";
string mySecondValue = "Some Words";

if (myFirstValue.Equals(mySecondValue))
{
	Console.WriteLine("equal");
}
if (myFirstValue.Equals(mySecondValue.ToLower()))
{
	Console.WriteLine("equal without case sensitivity");
}
else
{
	Console.WriteLine("not equal");
}
