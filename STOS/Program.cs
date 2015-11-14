using System;

namespace STOS
{
	class Program
	{
		static void Main(string[] args)
		{
			int size = 0;
			int[] stack = new int[10];
			string inp;
			do
			{
				inp = Console.ReadLine();
				if (!string.IsNullOrEmpty(inp))
				{
					if (inp == "+")
					{
						if (size < 10)
						{
							stack[size] = int.Parse(Console.ReadLine());
							size++;
							Console.WriteLine(":)");
						}
						else
						{
							Console.WriteLine(":(");
						}
					}
					else
					{
						if (inp == "-")
						{
							if (size > 0)
							{
								size--;
								Console.WriteLine(stack[size]);
							}
							else
							{
								Console.WriteLine(":(");
							}
						}
					}
				}
			} while (!string.IsNullOrEmpty(inp));
		}
	}
}
