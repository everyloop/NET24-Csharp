

using System.Collections;

foreach(var number in GetNumbers())
{
    Console.WriteLine(number);
}

IEnumerable GetNumbers()
{
	for (int i = 0; i < 10; i++)
	{
		yield return i;
	}
}