#define _CRT_SECURE_NO_WARNINGS
#include <cstdio>
#include <cmath>

using namespace std;

int main()
{
	int c, n;
	scanf("%d", &c);
	for (int i = 0; i < c; i++)
	{
		scanf("%d", &n);
		bool ans = true;
		if (n ==1)
		{
			printf("NIE\n");
		}
		else
		{
			for (int ii = 2; ii < sqrt(n); ii++)
			{
				if (n % ii == 0)
				{
					ans = false;
					printf("NIE\n");
					continue;
				}
			}
			if (ans)
				printf("TAK\n");
		}
	}
}