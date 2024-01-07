using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
	private static void Main(string[] args)
	{
		List<int> myNumberList = [2, 3, 5, 6, 7, 9, 10, 123, 324, 54];

		foreach (int number in myNumberList)
		{
			PrintIfOdd(number);
		}
	}

	private static void PrintIfOdd(int number)
	{
		if (number % 2 > 0)
		{
			Console.WriteLine(number);
		}
	}
}