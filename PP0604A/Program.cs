using System;

namespace PP0604A
{
	class Program
	{
		static double GetDifference(double x, double y)
		{
			if (x >= y)
				return x - y;
			else
				return y-x;
		}
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				string inp = Console.ReadLine();
				string[] data = inp.Split(' ');
				int size = int.Parse(data[0]);
				int[] numbers = new int[size];
				int sum = 0;
				for (int j = 1; j <= size; j++)
				{
					numbers[j - 1] = int.Parse(data[j]);
					sum += numbers[j - 1];
				}
				double average = (double) sum/(double) size;
				int closest = numbers[0];
				double gap = GetDifference(closest, average);
				for (int j = 1; j < size; j++)
				{
					double temp = GetDifference(numbers[j], average);
					if (temp < gap)
					{
						gap = temp;
						closest = numbers[j];
					}
				}
				Console.WriteLine(closest);
			}
		}
	}
}
