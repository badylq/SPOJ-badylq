using System;
using System.Collections.Generic;
using System.Text;

namespace FR_02_06
{
	class Program
	{
		static void Main(string[] args)
		{
			int t;
			String s;
			String[] niedowaga = new String[100];
			String[] norma = new String[100];
			String[] nadwaga = new String[100];
			int a = 0, b = 0, c = 0;
			t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				s = Console.ReadLine();
				String[] dane = s.Split(' ');
				String imie = dane[0];
				double bmi = (int.Parse(dane[1]) / ((double.Parse(dane[2]) / 100) * (double.Parse(dane[2]) / 100)));
				if (bmi >= 25)
				{
					nadwaga[c] = imie;
					c++;
				}
				else
					if (bmi >= 18.5)
				{
					norma[b] = imie;
					b++;
				}
				else
				{
					niedowaga[a] = imie;
					a++;
				}
			}
			Console.WriteLine("niedowaga");
			for (int i = 0; i < a; i++)
			{
				Console.WriteLine(niedowaga[i]);
			}
			Console.WriteLine("\nwartosc prawidlowa");
			for (int i = 0; i < b; i++)
			{
				Console.WriteLine(norma[i]);
			}
			Console.WriteLine("\nnadwaga");
			for (int i = 0; i < c; i++)
			{
				Console.WriteLine(nadwaga[i]);
			}
		}
	}
}


