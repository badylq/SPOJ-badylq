using System;

namespace PROGC01
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			string inp = Console.ReadLine();
			while (inp != null)
			{
				++sum;
				inp = Console.ReadLine();
			}
			Console.WriteLine(sum);
		}
	}
}
