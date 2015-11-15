using System;

namespace PP0602B
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
				int l = int.Parse(data[0]);
				int k = int.Parse(data[1]);
				int[,] matrix = new int[l,k];
				for (int j = 0; j < l; j++)
				{
					inp = Console.ReadLine();
					data = inp.Split(' ');
					for (int m = 0; m < k; m++)
					{
						matrix[j, m] = int.Parse(data[m]);
					}
				}
				int backup = matrix[0, 0];
				for (int j = 0; j < k - 1; j++)
				{
					matrix[0, j] = matrix[0, j + 1];
				}
				for (int j = 0; j < l - 1; j++)
				{
					matrix[j, k - 1] = matrix[j + 1, k - 1];
				}
				for (int j = k - 1; j > 0; j--)
				{
					matrix[l - 1, j] = matrix[l - 1, j - 1];
				}
				for (int j = l - 1; j > 1; j--)
				{
					matrix[j, 0] = matrix[j - 1, 0];
				}
				matrix[1, 0] = backup;
				for (int j = 0; j < l; j++)
				{
					for (int m = 0; m < k; m++)
					{
						Console.Write(matrix[j, m] + " ");
					}
					Console.WriteLine();
				}
			}
		}
	}
}
