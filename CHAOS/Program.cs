using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAOS
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string[] godzina = Console.ReadLine().Split(':');
				int hh = Convert.ToInt32(godzina[0]);
				int mm = Convert.ToInt32(godzina[1]);
				if (hh == 23 && mm > 32)
				{
					Console.WriteLine("00:00");
					continue;
				}
				if (hh>=10 )
				{
					if (((hh == 15 && mm > 50) || hh > 15) && hh < 20)
					{
						Console.WriteLine("20:02");
						continue;
					}
					if (hh == 23 && mm == 32)
					{
						Console.WriteLine("00:00");
						continue;
					}
					if (mm < Convert.ToInt32(String.Join("", godzina[0].ToCharArray().Reverse().ToList())))
						Console.WriteLine(String.Format("{0}:{1}", hh, String.Join("", godzina[0].ToCharArray().Reverse().ToList())));
					else
					{
						Console.WriteLine(String.Format("{0}:{1}", hh + 1, String.Join("", (hh + 1).ToString().ToCharArray().Reverse().ToList())));
					}
				}
				else
				{
					if (hh == 0 && mm < 55)
					{
						if (mm < 9)
						{
							Console.WriteLine("00:0{0}", mm + 1);
						}
						else
						{
							if (godzina[1][0] > godzina[1][1])
							{
								Console.WriteLine("00:{0}{0}", godzina[1][0]);
							}
							else
							{
								Console.WriteLine("00:{0}{0}", (char)((int)godzina[1][0] + 1));
							}
						}
					}
					else
					{
						if (godzina[0][1] <= godzina[1][1])
						{
							if (godzina[1][0] == '5')
							{
								if (godzina[0][1] == '9')
									Console.WriteLine(String.Format("{0}:{1}", hh + 1,
										String.Join("", (hh + 1).ToString("D2").ToCharArray().Reverse().ToList())));
								else
									Console.WriteLine(String.Format("{0:D2}:{0:D2}", hh + 1));
							}
							else
							{
								Console.WriteLine("{0:D2}:{1}{2}", hh, (char)((int)godzina[1][0] + 1), godzina[0][1]);
							}
						}
						else
						{
							Console.WriteLine("{0:D2}:{1}{2}", hh, godzina[1][0], godzina[0][1]);
						}
					}
				}
			}
		}
	}
}
