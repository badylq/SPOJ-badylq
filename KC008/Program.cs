using System;
using System.Linq;

namespace KC008
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp;
			Int64 totalSum = 0;
			inp = Console.ReadLine();
			while (!String.IsNullOrWhiteSpace(inp))
			{
				Int64 sum = 0;
				Int64[] nums = inp.Split(' ').ToList().ConvertAll(Convert.ToInt64).ToArray();
				foreach (var num in nums)
				{
					sum += num;
				}
				Console.WriteLine(sum);
				totalSum += sum;
				inp = Console.ReadLine();
			}
			Console.WriteLine(totalSum);
		}
	}
}
