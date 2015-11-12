using System;

namespace PTCLTZ
{
	class Program
	{
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				int n = 0;
				int x = int.Parse(Console.ReadLine());
				while (x != 1)
				{
					if (x%2 == 0)
					{
						x = x/2;
					}
					else
					{
						x = 3*x + 1;
					}
					n++;
				}
				Console.WriteLine(n);
			}
		}
	}
}
