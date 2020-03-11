using System;

public class Factorial
{
	public static void Fact()
	{
		Console.WriteLine(" Enter teh number to find the factorial");
		var input = int.Parse(Console.ReadLine());
		var fact = 1;
		for (int i = input; i > 1; i--)
		{
			fact = fact * i;
		}
		Console.WriteLine("The Factorial of {0}", input + "is " + fact + "\n");

		Console.WriteLine(" Do you Want to Continue Y/N ");
		var dec = Console.ReadLine().ToLower();
		if (dec == "y")
		{
			Fact();
		}


	}
	public static void Main(string[] args)
	{
		Fact();
	}
}
