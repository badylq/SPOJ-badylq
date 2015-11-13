using System;

namespace SUMA
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp;
			int result = 0;
			bool end = false;
			do
			{
				inp = Console.ReadLine();
				if (!String.IsNullOrEmpty(inp))
				{
					result += int.Parse(inp);
					Console.WriteLine(result);
				}
				else
				{
					end = true;
				}
			} while (!end);
		}
	}
}
