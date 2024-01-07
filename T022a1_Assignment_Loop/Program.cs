List<int> myNumberList = [2, 3, 5, 6, 7, 9, 10, 123, 324, 54];

foreach (int n in myNumberList)
{
	if (n % 2 == 0)
	{
		Console.WriteLine(n);
	}
}
