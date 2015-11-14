using System;

namespace CALC
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp;
			do
			{
				inp = Console.ReadLine();
				if (!string.IsNullOrEmpty(inp))
				{
					string[] data = inp.Split(' ');
					if (data[0] == "+")
					{
						Console.WriteLine(int.Parse(data[1]) + int.Parse(data[2]));
					}
					if (data[0] == "-")
					{
						Console.WriteLine(int.Parse(data[1]) - int.Parse(data[2]));
					}
					if (data[0] == "*")
					{
						Console.WriteLine(int.Parse(data[1]) * int.Parse(data[2]));
					}
					if (data[0] == "/")
					{
						Console.WriteLine(int.Parse(data[1]) / int.Parse(data[2]));
					}
					if (data[0] == "%")
					{
						Console.WriteLine(int.Parse(data[1]) % int.Parse(data[2]));
					}
				}
			} while (!string.IsNullOrEmpty(inp));
		}
	}
}
