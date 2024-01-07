Dictionary<string, decimal> itemPrices = new()
{
	{"cheese",5.99m },
	{"carrots",2.99m }
};

Console.WriteLine(itemPrices["cheese"].GetType());
Console.WriteLine(itemPrices["cheese"]);
Console.WriteLine(itemPrices["carrots"]);