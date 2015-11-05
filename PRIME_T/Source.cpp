#define _CRT_SECURE_NO_WARNINGS
#include <cstdio>

using namespace std;

int main()
{
	int c, n;
	scanf("%d", &n);
	for (int i = 0; i < n; i++)
	{
		int prime = 0;
		scanf("%d", &c);
		if (c != 1)
		{
			for (int j = 1; j <= c; j++)
			{
				if (c%j == 0)
				{
					++prime;
					continue;
				}
			}

			if (prime > 2)
			{
				printf("NIE\n");
			}
			else
			{
				printf("TAK\n");
			}
		}
		else
		{
			printf("NIE\n");
		}
	}
}