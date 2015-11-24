using System;

namespace FR_04_02
{
	class Program
	{
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				string inp = Console.ReadLine();
				string[] data = inp.Split(' ');
				int a = int.Parse(data[0]);
				int b = int.Parse(data[1]);
				if (a%2 != 0)
				{
					Console.WriteLine("BRAK");
				}
				else
				{
					b += (a/2);
					if (b > a)
					{
						b -= a;
					}
					Console.WriteLine(b);
				}
			}
		}
	}
}
