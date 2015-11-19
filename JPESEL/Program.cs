using System;

namespace JPESEL
{
	class Program
	{
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				string inp = Console.ReadLine();
				int[] pesel = new int[11];
				for (int j = 0; j < 11; j++)
				{
					pesel[j] = inp[j] - '0';
				}
				pesel[1] *= 3;
				pesel[2] *= 7;
				pesel[3] *= 9;
				pesel[5] *= 3;
				pesel[6] *= 7;
				pesel[7] *= 9;
				pesel[9] *= 3;
				int control = 0;
				foreach (var num in pesel)
				{
					control += num;
				}
				if (control%10 == 0)
				{
					Console.WriteLine("D");
				}
				else
				{
					Console.WriteLine("N");
				}
			}
		}
	}
}
