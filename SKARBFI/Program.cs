using System;

namespace SKARBFI
{
	class Program
	{
		static void Main(string[] args)
		{
			int n, m;
			int h, v;
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				h = 0;
				v = 0;
				m = int.Parse(Console.ReadLine());
				for (int j = 0; j < m; j++)
				{
					string inp = Console.ReadLine();
					string[] data = inp.Split(' ');
					if (data[0] == "0")
					{
						v += int.Parse(data[1]);
					}
					else
					{
						if (data[0] == "1")
						{
							v -= int.Parse(data[1]);
						}
						else
						{
							if (data[0] == "2")
							{
								h -= int.Parse(data[1]);
							}
							else
							{
								h += int.Parse(data[1]);
							}
						}
					}
				}
				if (v == 0 && h == 0)
				{
					Console.WriteLine("studnia");
				}
				else
				{
					if (v != 0)
					{
						if (v < 0)
						{
							Console.WriteLine("1 " + (v*-1));
						}
						else
						{
							Console.WriteLine("0 " + v);
						}
					}
					if (h != 0)
					{
						if (h < 0)
						{
							Console.WriteLine("2 " + (h * -1));
						}
						else
						{
							Console.WriteLine("3 " + h);
						}
					}
				}
			}
		}
	}
}
