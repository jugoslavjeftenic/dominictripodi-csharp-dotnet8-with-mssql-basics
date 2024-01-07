internal class Program
{
	static int _accessibleInt = 7;

	private static void Main(string[] args)
	{
		Console.WriteLine(_accessibleInt);

		TestMethod();
	}

	static void TestMethod()
	{
		int accessibleInt = 5;
		Console.WriteLine(accessibleInt);
	}
}