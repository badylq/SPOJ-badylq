using System;

namespace PTROL
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
				int n = int.Parse(data[0]);
				for (int j = 2; j < n+1; j++)
				{
					Console.Write(data[j] + " ");
				}
				Console.WriteLine(data[1]);
			}
		}
	}
}
