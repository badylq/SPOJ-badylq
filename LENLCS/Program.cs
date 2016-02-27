using System;

namespace LENLCS
{
	class Program
	{
		static void Main(string[] args)
		{
			int d, n, m;
			string u, v;
			d = int.Parse(Console.ReadLine());
			for (int i = 0; i < d; i++)
			{
				n = int.Parse(Console.ReadLine());
				u = Console.ReadLine();
				m = int.Parse(Console.ReadLine());
				v = Console.ReadLine();
				int[,] tab = new int[++n,++m];
				for (int j = 0; j < n; j++)
				{
					tab[j, 0] = 0;
				}
				for (int j = 1; j < m; j++)
				{
					tab[0, j] = 0;
				}

				for (int j = 1; j < n; j++)
				{
					for (int k = 1; k < m; k++)
					{
						if (u[j - 1] == v[k - 1])
						{
							tab[j, k] = tab[j - 1, k - 1] + 1;
						}
						else
						{
							tab[j, k] = tab[j - 1, k] > tab[j, k - 1] ? tab[j - 1, k] : tab[j, k - 1];
						}
					}
				}
				Console.WriteLine(tab[n-1,m-1]);
			}
		}
	}
}
