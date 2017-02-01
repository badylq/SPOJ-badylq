using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KC009
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp;
			inp = Console.ReadLine();
			while (!String.IsNullOrWhiteSpace(inp))
			{
				for (int i = inp.Length-1; i >=0; i--)
				{
					Console.Write(inp[i]);
				}
				Console.WriteLine();
				inp = Console.ReadLine();
			}
		}
	}
}
