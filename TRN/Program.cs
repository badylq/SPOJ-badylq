using System;

namespace TRN
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp = Console.ReadLine();
			string[] data = inp.Split(' ');
			int x = int.Parse(data[0]);
			int y = int.Parse(data[1]);
			int[,] matrix = new int[x,y];
			for (int i = 0; i < x; i++)
			{
				inp = Console.ReadLine();
				data = inp.Split(' ');
				for (int j = 0; j < y; j++)
				{
					matrix[i, j] = int.Parse(data[j]);
				}
			}

			for (int i = 0; i < y; i++)
			{
				for (int j = 0; j < x; j++)
				{
					Console.Write(matrix[j,i] + " ");
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}
