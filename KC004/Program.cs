using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KC004
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp = Console.ReadLine();
			while (!String.IsNullOrWhiteSpace(inp))
			{
				List<int> nums = inp.Split(' ').ToList().ConvertAll(Convert.ToInt32);
				Console.WriteLine(nums.GetRange(2, nums[1]).Count(x => x.Equals(nums[0])));
				inp = Console.ReadLine();
			}
		}
	}
}
