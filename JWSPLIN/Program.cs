using System;

namespace JWSPLIN
{
	class Program
	{
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				string inp = Console.ReadLine();
				string[] data = inp.Split('\t');
				int[,] points = new int[3, 2];
				points[0, 0] = int.Parse(data[0]);
				points[0, 1] = int.Parse(data[1]);
				points[1, 0] = int.Parse(data[2]);
				points[1, 1] = int.Parse(data[3]);
				points[2, 0] = int.Parse(data[4]);
				points[2, 1] = int.Parse(data[5]);
				if (points[0, 0] == points[1, 0])
				{
					if (points[0, 0] == points[2, 0])
					{
						Console.WriteLine("TAK");
					}
					else
					{
						Console.WriteLine("NIE");
					}
				}
				else
				{
					int a, b;
					a = (points[0, 1] + (-1*points[1, 1])) / (points[0, 0] - points[1, 0]);
					b = (a*points[0, 0] - points[0, 1])*-1;
					if (points[2, 1] == a*points[2, 0] + b)
					{
						Console.WriteLine("TAK");
					}
					else
					{
						Console.WriteLine("NIE");
					}
				}
			}
		}
	}
}
