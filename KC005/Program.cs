using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KC005
{
	class Program
	{
		static bool WalidujImN(string imn)
		{
			try
			{
				if (imn[0] > 90 || imn[0] < 65)
					return true;
				for (int i = 1; i < imn.Length; i++)
				{
					if (imn[i] < 97 || imn[i] > 122)
						return true;
				}
			}
			catch
			{
				return true;
			}
			return false;
		}

		static bool WalidujDate(string data)
		{
			try { 
			List<int> d = data.Split('-').ToList().ConvertAll(Convert.ToInt32);
			if (d[0] < 1900 || d[0] > 2000)
				return true;
			if (d[1] < 1 || d[1] > 12)
				return true;
			if (d[2] < 1 || d[2] > 31)
				return true;
			}
			catch
			{
				return true;
			}
			return false;
		}

		static void Main(string[] args)
		{
			string inp = Console.ReadLine();
			while (!String.IsNullOrWhiteSpace(inp))
			{
				string[] dane = inp.Split(";".ToCharArray());
				if(WalidujImN(dane[0].Substring(6, dane[0].Length - 6)))
					Console.WriteLine("0");
				else if (WalidujImN(dane[1].Substring(11, dane[1].Length - 11)))
					Console.WriteLine("1");
				else if (WalidujDate(dane[2].Substring(11, dane[2].Length - 11)))
					Console.WriteLine("2");
				else 
					Console.WriteLine("3");
				inp = Console.ReadLine();
			}
		}
	}
}
