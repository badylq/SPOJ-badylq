using System;

namespace JHTMLLET
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp;
			while (!string.IsNullOrEmpty(inp = Console.ReadLine()))
			{
				bool isTag = false;
				foreach (var c in inp)
				{
					if (c == '<')
					{
						isTag = true;
						Console.Write(c);
					}
					else
					{
						if (c == '>')
						{
							isTag = false;
							Console.Write(c);
						}
						else
						{
							if (c >= 'A')
							{
								if (isTag && c >= 'a')
								{
									Console.Write((char)((int)c - 32));
								}
								else
								{
									Console.Write(c);
								}
							}
							else
							{
								Console.Write(c);
							}
						}
					}
				}
				Console.WriteLine();
			}
		}
	}
}
