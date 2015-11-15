using System;

namespace CALC2
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp;
			int[] stack = new[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
			do
			{
				inp = Console.ReadLine();
				if (!string.IsNullOrEmpty(inp))
				{
					string[] data = inp.Split(' ');
					if (data[0] == "+")
					{
						Console.WriteLine(stack[int.Parse(data[1])] + stack[int.Parse(data[2])]);
					}
					if (data[0] == "-")
					{
						Console.WriteLine(stack[int.Parse(data[1])] - stack[int.Parse(data[2])]);
					}
					if (data[0] == "*")
					{
						Console.WriteLine(stack[int.Parse(data[1])] * stack[int.Parse(data[2])]);
					}
					if (data[0] == "/")
					{
						Console.WriteLine(stack[int.Parse(data[1])] / stack[int.Parse(data[2])]);
					}
					if (data[0] == "%")
					{
						Console.WriteLine(stack[int.Parse(data[1])] % stack[int.Parse(data[2])]);
					}
					if (data[0] == "z")
					{
						stack[int.Parse(data[1])] = int.Parse(data[2]);
					}
				}
			} while (!string.IsNullOrEmpty(inp));
		}
	}
}
