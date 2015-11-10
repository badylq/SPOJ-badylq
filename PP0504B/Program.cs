using System;

namespace PP0504B
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int len;
			string output;
			for (int i = 0; i < n; i++)
			{
				string[] str = Console.ReadLine().Split(' ');
				if (str[0].Length > str[1].Length)
				{
					len = str[1].Length;
				}
				else
				{
					len = str[0].Length;
				}
				output = "";
				for (int j = 0; j < len; j++)
				{
					output += str[0][j];
					output += str[1][j];
				}
				Console.WriteLine(output);
			}
		}
	}
}
