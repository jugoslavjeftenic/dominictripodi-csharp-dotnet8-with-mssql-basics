
internal class Program
{
	private static void Main(string[] args)
	{
		int[] intsToCompress = [10, 15, 20, 25, 30, 12, 34];

		_ = GetSum(intsToCompress);
	}

	private static int GetSum(int[] intsToCompress)
	{
		int totalValue = 0;

		foreach (var n in intsToCompress)
		{
			totalValue += n;
		}

		return totalValue;
	}
}