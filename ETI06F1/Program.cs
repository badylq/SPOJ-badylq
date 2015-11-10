using System;

namespace ETI06F1
{
	class Program
	{
		static void Main(string[] args)
		{
			const double PI = 3.141592654;
            double r, d;
			string input = Console.ReadLine();
			string[] values = input.Split(' ');
			r = double.Parse(values[0]);
			d = double.Parse(values[1]);
			double rr = Math.Sqrt(r*r - (0.5*d)*(0.5*d));
			double cArea = PI*(rr*rr);
			Console.WriteLine(cArea);
		}
	}
}
