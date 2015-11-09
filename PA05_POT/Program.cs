using System;

namespace PA05_POT
{
	class Program
	{
		static void Main(string[] args)
		{
			int n, a, b;
			String  str = "0161656161012345678901496569410187456329";
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string inp = Console.ReadLine();
				string[] numbers = inp.Split(' ');
				a = int.Parse(numbers[0]);
				b = int.Parse(numbers[1]);
				Console.WriteLine(str[10 * (b%4) + (a%10)]);
			}
		}
	}
}
