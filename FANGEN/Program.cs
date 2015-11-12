using System;

namespace FANGEN
{
	class Program
	{
		private static void starsInCorners(ref char[,] matrix, int x, int n)
		{
			matrix[x, x] = '*';
			matrix[x, x + 2*n - 1] = '*';
			matrix[x + 2*n - 1, x] = '*';
			matrix[x + 2*n - 1, x + 2*n - 1] = '*';
		}

		private static void fan(ref char[,] matrix, int x, int n, bool right)
		{
			char c1;
			char c2;
			if (right)
			{
				c1 = '*';
				c2 = '.';
			}
			else
			{
				c1 = '.';
				c2 = '*';
			}
			int stars = 0;
			for (int i = 0; i < 2*n - 1; i++)
			{
				if (stars < n)
				{
					matrix[x, x + i] = c1;
					stars++;
				}
				else
				{
					matrix[x, x + i] = c2;
				}
			}

			stars = 0;
			for (int i = 0; i < 2 * n - 1; i++)
			{
				if (stars < n)
				{
					matrix[x + i, x + 2*n - 1] = c1;
					stars++;
				}
				else
				{
					matrix[x + i, x + 2*n - 1] = c2;
				}
			}

			stars = 0;
			for (int i = 0; i < 2 * n; i++)
			{
				if (stars < n)
				{
					matrix[x + 2 * n - 1, x + i] = c2;
					stars++;
				}
				else
				{
					matrix[x + 2 * n - 1, x + i] = c1;
				}
			}

			stars = 0;
			for (int i = 1; i < 2 * n; i++)
			{
				if (stars < n-1)
				{
					matrix[x + i, x] = c2;
					stars++;
				}
				else
				{
					matrix[x + i, x] = c1;
				}
			}
		}

		static void Main(string[] args)
		{
			int r = int.Parse(Console.ReadLine());
            do
			{
				int n = 1;
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
				char[,] matrix = new char[2*r,2*r];
				int x = r - 1;
				for (int i = 0; i < r; i++)
				{
					fan(ref matrix, x, n, right);
					if (!right)
					{
						starsInCorners(ref matrix, x, n);
					}
					x--;
					n++;
				}

				for (int i = 0; i < 2*r; i++)
				{
					for (int j = 0; j < 2*r; j++)
					{
						Console.Write(matrix[i,j]);
					}
					Console.Write('\n');
				}
				Console.WriteLine();
				r = int.Parse(Console.ReadLine());
			} while (r != 0);
		}
	}
}
