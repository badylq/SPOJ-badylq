using System;

namespace PP0602A
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
				int size = int.Parse(data[0]);
				for (int j = 2; j < size+1; j += 2)
				{
					Console.Write(data[j] + " ");
				}
				for (int j = 1; j < size + 1; j += 2)
				{
					Console.Write(data[j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
