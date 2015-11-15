using System;

namespace PP0601A2
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = 0;
			bool checker = true;
			int num;
            while (true)
			{
				Console.WriteLine(num = int.Parse(Console.ReadLine().Split()[0]));
				if (num == 42)
				{
					if (!checker)
					{
						counter++;
						checker = true;
					}
					if (counter == 3)
					{
						return;
					}
				}
				else
				{
					checker = false;
				}
			}
		}
	}
}
