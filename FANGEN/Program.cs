using System;
using System.Globalization;

namespace FANGEN
{
	class Program
	{
		static private char swap(char c)
		{
			if (c == '*')
				return '.';
			else
				return '*';
		}
		
		static void Main(string[] args)
		{
			int r = int.Parse(Console.ReadLine());
            do
			{
				bool right;
				if (r<0)
				{
					r = r*-1;
					right = true;
				}
				else
				{
					right = false;
				}

				int a,b,c,d;
				char[][] str = new char[r][];
				char c1;
				char c2;
				int mod = 1;
				if (right)
				{
					c1 = '*';
					c2 = '.';
					a = 0;
					b = r;
					c = r - 1;
					d = 1;
				}
				else
				{
					c1 = '.';
					c2 = '*';
					a = 1;
					b = r - 1;
					c = r;
					d = 0;
				}

				for (int j = 0; j < r; j++)
				{
					int ii = 0;
					str[j] = new char[2*r];
					for (int i = 0; i < a; i++)
					{
						str[j][ii] = c2;
						ii++;
					}
					for (int i = 0; i < b; i++)
					{
						str[j][ii] = c1;
						ii++;
					}
					for (int i = 0; i < c; i++)
					{
						str[j][ii] = c2;
						ii++;
					}
					for (int i = 0; i < d; i++)
					{
						str[j][ii] = c1;
						ii++;
					}

					a += mod;
					b -= mod;
					c -= mod;
					d += mod;
				}
				for (int i = 0; i < r; i++)
				{
					for (int j = 0; j < 2*r; j++)
					{
						Console.Write(str[i][j]);
					}
					Console.WriteLine();
				}
				
				for (int i = r-1; i >= 0; i--)
				{
					for (int j = 2*r - 1; j >=0; j--)
					{
						Console.Write(str[i][j]);
					}
					Console.WriteLine();
				}

				Console.WriteLine();
				r = int.Parse(Console.ReadLine());
			} while (r != 0);
		}
	}
}
