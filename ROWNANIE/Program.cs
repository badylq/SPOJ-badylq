using System;

namespace ROWNANIE
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp;
			double a, b, c;
			double delta;
			var end = false;
			do
			{
				inp = Console.ReadLine();
				if (String.IsNullOrEmpty(inp))
				{
					end = true;
				}
				else
				{
					string[] data = inp.Split(' ');
					a = double.Parse(data[0]);
					b = double.Parse(data[1]);
					c = double.Parse(data[2]);
					delta = b*b - 4*a*c;
					if (delta >= 0)
					{
						if (delta > 0)
						{
							Console.WriteLine("2");
						}
						else
						{
							Console.WriteLine("1");
						}
					}
					else
					{
						Console.WriteLine("0");
					}
				}
			} while (!end);
		}
	}
}
