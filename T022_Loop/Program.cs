int[] intsToCompress = [10, 15, 20, 25, 30, 12, 34];

Console.WriteLine(intsToCompress.Sum()); // 146

int totalValue = 0;

for (int i = 0; i < intsToCompress.Length; i++)
{
	totalValue += intsToCompress[i];
}
Console.WriteLine(totalValue);

totalValue = 0;
foreach (var intForCompression in intsToCompress)
{
	totalValue += intForCompression;
}
Console.WriteLine(totalValue);

totalValue = 0;
int index = 0;
while (index < intsToCompress.Length)
{
	totalValue += intsToCompress[index++];
}
Console.WriteLine(totalValue);

totalValue = 0;
index = 0;
do
{
	totalValue += intsToCompress[index++];
} while (index < intsToCompress.Length);
Console.WriteLine(totalValue);

totalValue = 0;
foreach (var intForCompression in intsToCompress)
{
	if (intForCompression > 20)
	{
		totalValue += intForCompression;
	}
}
Console.WriteLine(totalValue);
