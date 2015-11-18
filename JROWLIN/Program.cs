using System;

namespace JROWLIN
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp = Console.ReadLine();
			string[] data = inp.Split(' ');
			double a = double.Parse(data[0]);
			double b = double.Parse(data[1]);
			double c = double.Parse(data[2]);
			if (a == 0.0d)
			{
				if (b == c)
				{
					Console.WriteLine("NWR");
				}
				else
				{
					Console.WriteLine("BR");
				}
			}
			else
			{
				double result = (c - b) / a;
				Console.WriteLine("{0:0.00}", result);
			}
		}
	}
}
