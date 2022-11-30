using System;

public static class Globals
{
	internal static void Main()

	{
		Console.Write("Determinati daca n divide cu k");
		Console.Write("\n");
		int n;
		int k;

		Console.Write("n = ");
		n = Convert.ToInt32(Console.ReadLine());
		Console.Write("k = ");
		k = Convert.ToInt32(Console.ReadLine());


		if (n % k == 0 || k % n == 0)

		{

			Console.Write("DA");

		}

		else

		{

			Console.Write("NU");

		}



	}
}
