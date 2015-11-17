using System;

namespace MWPZ06H
{
	class Program
	{
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				int size = int.Parse(Console.ReadLine());
				string inp = Console.ReadLine();
				string[] data = inp.Split(' ');
				int[] numbers = new int[size];
				for (int j = 0; j < size; j++)
				{
					numbers[j] = int.Parse(data[j]);
				}
				Array.Sort(numbers);
				Console.Write(numbers[size-1] + " ");
				size--;
				for (int j = size-1; j >= 0; j--)
				{
					if (numbers[j] == numbers[j + 1])
					{
						Console.Write(numbers[j] + " ");
						size--;
					}
					else
					{
						j = -1;
					}
				}
				for (int j = 0; j < size; j++)
				{
					Console.Write(numbers[j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
