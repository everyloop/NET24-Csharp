
double[] temperatures = new double[] { 10.5, 19.7, 15.3, 12.6 };

for (int i = 0; i < 10; i++)
{
    temperatures[i] = 10 + 0.2 * i;
}

Console.WriteLine(string.Join(" - ", temperatures));

for (int i = 0; i < temperatures.Length; i++)
{
    Console.WriteLine(temperatures[i]);
}

Console.WriteLine("***************");

foreach (double temperature in temperatures)
{
    Console.WriteLine(temperature);
}


