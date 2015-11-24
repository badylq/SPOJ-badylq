using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_04_08
{
	class Program
	{
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				string inp = Console.ReadLine();
				string[] data = inp.Split(' ');
				int a = int.Parse(data[0]);
				int b = int.Parse(data[1]);

				int[,] spiral = new int[a,b];
				int value = 1;
				int minCol = 0;
				int maxCol = b - 1;
				int minRow = 0;
				int maxRow = a - 1;

				while (value <= a*b)
				{
					{
						for (int j = minCol; j <= maxCol; j++)
						{
							spiral[minRow, j] = value;
							value++;
						}
					}
					{
						for (int j = minRow + 1; j <= maxRow; j++)
						{
							spiral[j, maxCol] = value;
							value++;
						}
					}
					if (value <= a * b)
					{
						for (int j = maxCol - 1; j >= minCol; j--)
						{
							spiral[maxRow, j] = value;
							value++;
						}
					}
					if (value <= a*b)
					{
						for (int j = maxRow - 1; j >= minRow + 1; j--)
						{
							spiral[j, minCol] = value;
							value++;
						}
					}

					minCol++;
					minRow++;
					maxCol--;
					maxRow--;
				}
				int len = value.ToString().Length;

				switch (len)
				{
					case 2:
						for (int j = 0; j < a; j++)
						{
							for (int k = 0; k < b; k++)
							{
								Console.Write("{0:D2}", spiral[j, k]);
								if (k < b - 1)
									Console.Write(' ');
							}
							Console.WriteLine();
						}
						break;
					case 3:
						for (int j = 0; j < a; j++)
						{
							for (int k = 0; k < b; k++)
							{
								Console.Write("{0:D3}", spiral[j, k]);
								if (k < b - 1)
									Console.Write(' ');
							}
							Console.WriteLine();
						}
						break;
					case 4:
						for (int j = 0; j < a; j++)
						{
							for (int k = 0; k < b; k++)
							{
								Console.Write("{0:D4}", spiral[j, k]);
								if (k < b - 1)
									Console.Write(' ');
							}
							Console.WriteLine();
						}
						break;
					case 5:
						for (int j = 0; j < a; j++)
						{
							for (int k = 0; k < b; k++)
							{
								Console.Write("{0:D5}", spiral[j, k]);
								if (k < b - 1)
									Console.Write(' ');
							}
							Console.WriteLine();
						}
						break;
					default:
						for (int j = 0; j < a; j++)
						{
							for (int k = 0; k < b; k++)
							{
								Console.Write(spiral[j, k]);
								if (k < b - 1)
									Console.Write(' ');
							}
							Console.WriteLine();
						}
						break;
				}
				
			}
		}
	}
}
