using System;

namespace PA05_POT
{
	class Program
	{
		static void Main(string[] args)
		{
			int n, a, b;
			int[,] powrs = new int[,]
			{
				{0, 0, 0, 0}, {1, 1, 1, 1}, {6, 2, 4, 8}, {1, 3, 9, 7}, {6, 4, 6, 4},
				{5, 5, 5, 5}, {6, 6, 6, 6}, {6, 8, 4, 2}, {1, 9, 1, 9}
			};
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string inp = Console.ReadLine();
				string[] numbers = inp.Split(' ');
				a = int.Parse(numbers[0]);
				b = int.Parse(numbers[1]);
				int pow;
				if (b == 0)
				{
					pow = 1;
				}
				else
				{
					a = a%10;
					int x = b%4;
					pow = powrs[a, x];
				}
				Console.WriteLine(pow);
			}
		}
	}
}
