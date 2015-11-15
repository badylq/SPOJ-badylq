using System;
using System.Collections.Generic;

namespace SYS
{
	class Program
	{
		static private string Convert(int x)
		{
			List<int> number = new List<int>();
			string num = "";
			do
			{
				number.Add(x%11);
				x = (x - x%11)/11;
			} while (x>0);
			number.Reverse();
			foreach (var n in number)
			{
				{
					if (n == 10)
					{
						num += 'A';
					}
					else
					{
						num += n.ToString();
					}
				}
			}
			return num;
		}
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				int n = int.Parse(Console.ReadLine());
				string m = Convert(n);
				Console.WriteLine("{0:X} {1}", n, m);

			}
		}
	}
}
