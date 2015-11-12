using System;

namespace BINOMS
{
	class Program
	{
		private static int factorial(int x, int startFrom = 1)
		{
			int result = 1;
			for (int i = startFrom; i <= x; i++)
			{
				result *= i;
			}
			return result;
		}
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				string inp = Console.ReadLine();
				string[] data = inp.Split(' ');
				int n = int.Parse(data[0]);
				int k = int.Parse(data[1]);
				if (k > n/2)
				{
					k = n - k;
				}
				int[] nn = new int[k];
				int[] kk = new int[k];
				for (int j = n-k+1,m=0; j <= n; j++, m++)
				{
					nn[m] = j;
				}
				for (int j = 0; j < k; j++)
				{
					kk[j] = j+1;
				}

				for (int j = 0; j < k; j++)
				{
					for (int l = 1; l < k; l++)
					{
						if (kk[l] != 1 && nn[j]%kk[l] == 0)
						{
							nn[j] /= kk[l];
							kk[l] = 1;
						}
					}
				}
				decimal kkk = 1;
				decimal nnn = 1;
				foreach (var num in kk)
				{
					kkk *= num;
				}
				foreach (var num in nn)
				{
					nnn *= num;
				}
				Console.WriteLine(nnn/kkk);
			}
		}
	}
}
