using System;

namespace JSPACE
{
	class Program
	{
		private static void Main(string[] args)
		{
			string line;
			while (!string.IsNullOrEmpty(line = Console.ReadLine()))
			{
				bool bigLetter;
				string[] data = line.Split(' ');
				Console.Write(data[0]);
				for (int i = 1; i < data.Length; i++)
				{
					bigLetter = true;
					foreach (var c in data[i])
					{
						if (c >= 65)
						{
							if (c >= 97)
							{
								if (bigLetter)
								{
									Console.Write((char)((int)c - 32));
									bigLetter = false;
								}
								else
								{
									Console.Write(c);
								}
							}
							else
							{ 
								bigLetter = false;
								Console.Write(c);
							}
						}
						else
						{
							if (c != 32)
							{
								Console.Write((char)c);
							}
						}
					}
				}
				Console.WriteLine();
			}
		}
	}
}
