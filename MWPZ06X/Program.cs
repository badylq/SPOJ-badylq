using System;

namespace MWPZ06X
{
	class Program
	{
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				int a = int.Parse(Console.ReadLine());
				Console.WriteLine(a*a);
			}
		}
	}
}
