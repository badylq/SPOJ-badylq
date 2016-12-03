using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEGA
{
	class Program
	{
		static void Main(string[] args)
		{
			int t = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				string inp = Console.ReadLine();
				int n;
				List<int> nums = inp.Split(' ').ToList().ConvertAll(Convert.ToInt32);
				n = nums[0];
				nums.RemoveAt(0);
				Console.WriteLine(n-1 + nums.Sum());
			}
		}
	}
}
