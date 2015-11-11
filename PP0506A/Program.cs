using System;
using System.Collections.Generic;

namespace PP0506A
{
	class MyPoint : IComparable
	{
		public MyPoint(string name, int x, int y)
		{
			this.name = name;
			this.x = x;
			this.y = y;
			distance = Math.Sqrt(x*x + y*y);
		}

		private string name;
		private int x, y;
		private double distance;
		public int CompareTo(object obj)
		{
			MyPoint p = (MyPoint) obj;
			if (this.distance > p.distance)
			{
				return 1;
			}
			if (this.distance < p.distance)
			{
				return -1;
			}
			else
			{
				return 0;
			}
		}

		public void WriteLine()
		{
			Console.WriteLine(name + " " + x + " " + y);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int n, t;
			List<MyPoint> points;
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				t = int.Parse(Console.ReadLine());
				points = new List<MyPoint>();
                for (int j = 0; j < t; j++)
				{
					string inp = Console.ReadLine();
					string[] data = inp.Split(' ');
					points.Add(new MyPoint(data[0], int.Parse(data[1]), int.Parse(data[2])));
				}
				points.Sort();
				foreach (var point in points)
				{
					point.WriteLine();
				}
				Console.WriteLine();
				Console.ReadLine();
			}
		}
	}
}
