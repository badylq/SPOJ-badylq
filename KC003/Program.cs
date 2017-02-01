using System;
using System.Collections.Generic;
using System.Linq;

namespace KC003
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp = Console.ReadLine();
			while (!String.IsNullOrWhiteSpace(inp))
			{
				List<double> nums = inp.Split(' ').ToList().ConvertAll(Convert.ToDouble).ToList();
				Console.WriteLine((nums[0] < nums[1] + nums[2] && nums[1] < nums[2] + nums[0] && nums[2] < nums[1] + nums[0]) ? "1" : "0");
				inp = Console.ReadLine();
			}
		}
	}
}
