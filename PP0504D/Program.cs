using System;
using System.Text;

namespace PP0504D
{
	class Program
	{
		private static void printFloat(float number)
		{
			byte[] bytes = BitConverter.GetBytes(number);
			Array.Reverse(bytes);
			StringBuilder hex = new StringBuilder(bytes.Length * 2);
			foreach (byte b in bytes)
			{
				if (b < 16)
				{
					hex.AppendFormat("{0:x1}", b);
				}
				else
				{
					hex.AppendFormat("{0:x2}", b);
				}
				hex.Append(" ");
			}
			Console.WriteLine(hex);
		}
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				float num = float.Parse(Console.ReadLine());
				printFloat(num);
				
			}
		}
	}
}
