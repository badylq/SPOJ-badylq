#include <cstdio>

int main()
{
	int n;
	scanf("%d", &n);
	if (n < 3)
	{
		if (n == 0)
		{
			printf("0");
		}
		else
		{
			printf("NIE");
		}
	}
	else
	{
		int x = n;
		if (n % 2 != 0)
		{
			++x;
		}
		for (int i = 0; i < x / 2 - 1; i++)
		{
			printf("%d %d ", i + 1, n - i);
		}
		if (n % 2 == 0)
		{
			printf("%d ", n / 2);
		}
		printf("0 %d", n / 2 + 1);
	}
}
