using System;

public class Polyndrome
{
	public static void Main()
	{
		Console.WriteLine(" Enter a number to check if its Polyndrome");
		var input = int.Parse(Console.ReadLine());
		int temp, sum = 0, i;
		for (i = input; i > 1; i++)
		{
			temp = i % 10;
			sum = sum * 10 + temp;
			i = i / 10;
		}
		if (sum == input)
		{
			Console.WriteLine("The given number {0} is a Polyndrome", input);
		}
		else
		{
			Console.WriteLine("The given number {0} is a not a Polyndrome", input);
		}
	}
}
