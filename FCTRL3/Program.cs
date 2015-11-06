using System;

namespace FCTRL3
{
	class Program
	{
		static private int Factorial(int number)
		{
			int factorial = 1;
			for (int i = 1; i <= number; i++)
			{
				factorial *= i;
			}
			return factorial;
		}
		static void Main(string[] args)
		{
			int n, D;
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				D = int.Parse(Console.ReadLine());
				if (D <= 1)
				{
					Console.WriteLine("0 1");
				}
				else
				{
					if (D > 10)
					{
						Console.WriteLine("0 0");
					}
					else
					{
						string number = Factorial(D).ToString();
						if (number.Length == 1)
						{
							Console.Write("0 ");
						}
						else
						{
							Console.Write(number[number.Length - 2] + " ");
						}
						Console.WriteLine(number[number.Length - 1]);
					}
				}
			}
		}
	}
}
