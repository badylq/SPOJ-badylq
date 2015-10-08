#define _CRT_SECURE_NO_WARNINGS
#include <cstdio>

int main()
{
	int n, b[2];
	scanf("%i", &n);
	for (int i = 0; i < n; i++)
	{
		scanf("%d %d", &b[0], &b[1]);
		while (b[0] != b[1])
		{
			if (b[0] > b[1])
			{
				b[0] -= b[1];
			}
			else
			{
				b[1] -= b[0];
			}
		}
		printf("%d\n", b[0] + b[1]);
	}
}