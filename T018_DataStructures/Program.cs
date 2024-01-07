string[] myGroceryArray = new string[2];

myGroceryArray[0] = "Guacamole";
myGroceryArray[1] = "Ice Cream";

Console.WriteLine(myGroceryArray[0]);
Console.WriteLine(myGroceryArray[1]);
//Console.WriteLine(myGroceryArray[2]);

string[] mySecondGroceryArray = { "Apples", "Eggs" };

Console.WriteLine(mySecondGroceryArray[0]);
Console.WriteLine(mySecondGroceryArray[1]);

string[] myThirdGroceryArray = ["Oranges", "Carots"];
myThirdGroceryArray[1] = "Onions";

Console.WriteLine(myThirdGroceryArray[0]);
Console.WriteLine(myThirdGroceryArray[1]);

List<string> myGroceryList = new List<string>() { "Milk", "Cheese" };

Console.WriteLine(myGroceryList[0]);
Console.WriteLine(myGroceryList[1]);
//Console.WriteLine(myGroceryList[2]);

myGroceryList.Add("Cow");
Console.WriteLine(myGroceryList[2]);

IEnumerable<string> myGroceryIEnumerable = myGroceryList;
Console.WriteLine(myGroceryIEnumerable.First());

string[,] myTwoDimensionalArray = new string[,]
{
	{ "Apples", "Eggs" },
	{ "Milk", "Cheese" }
};
Console.WriteLine(myTwoDimensionalArray[1, 0]);

Dictionary<string, string[]> myGroceryDictionary = new Dictionary<string, string[]>()
{
	{"Diary",new string[]{"Cheese", "Milk", "Eggs" } }
};
Console.WriteLine(myGroceryDictionary["Diary"][2]);
