using System;

namespace PP0502B
{
	class Program
	{
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());
			string input;
			for (int i = 0; i < t; i++)
			{
				input = Console.ReadLine();
				string[] numbers = input.Split(' ');
				int[] nums = new int[numbers.Length - 1];
				for (int j = 1; j < numbers.Length; j++)
				{
					nums[j - 1] = int.Parse(numbers[j]);
				}
				Array.Reverse(nums);
				Console.Write(nums[0]);
				for (int j = 1; j < nums.Length; j++)
				{
					Console.Write(" " + nums[j]);
				}
				Console.Write("\n");
			}

		}
	}
}
