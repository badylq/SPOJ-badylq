using System;

namespace FR_04_05
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
				double r1 = double.Parse(data[0]);
				double r2 = double.Parse(data[1]);
				double wyn = 2*r1*r2;
				Console.WriteLine("{0:0.00}", wyn);
			}
		}
	}
}
