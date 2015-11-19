using System;

namespace PP0602D
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp = Console.ReadLine();
			string[] data = inp.Split(' ');
			int k = int.Parse(data[1]);
			int n = int.Parse(data[0]);
			inp = Console.ReadLine();
			data = inp.Split(' ');
			for (int j = k; j < n; j++)
			{
				Console.Write(data[j] + " ");
			}
			for (int j = 0; j < k; j++)
			{
				Console.Write(data[j] + " ");
			}
		}
	}
}
