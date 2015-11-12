#define _CRT_SECURE_NO_WARNINGS
#include <cstdio>

char swap(char c)
{
	if (c == '*')
		return '.';
	else
		return '*';
}

int main()
{
	int r;
	scanf("%d", &r);
	do
	{
		bool right;
		if (r < 0)
		{
			r = r * -1;
			right = true;
		}
		else
		{
			right = false;
		}

		int a, b, c, d;
		char c1;
		char c2;
		int mod = 1;
		if (right)
		{
			c1 = '*';
			c2 = '.';
			a = 0;
			b = r;
			c = r - 1;
			d = 1;
		}
		else
		{
			c1 = '.';
			c2 = '*';
			a = 1;
			b = r - 1;
			c = r;
			d = 0;
		}

		for (int j = 0; j < 2 * r; j++)
		{
			for (int i = 0; i < a; i++)
			{
				printf("%c", c2);
			}
			for (int i = 0; i < b; i++)
			{
				printf("%c", c1);
			}
			for (int i = 0; i < c; i++)
			{
				printf("%c", c2);
			}
			for (int i = 0; i < d; i++)
			{
				printf("%c", c1);
			}

			if (j == r - 1)
			{
				mod = -1;
				int temp = b;
				b = c;
				c = temp;
				temp = a;
				a = d;
				d = temp;
				c1 = swap(c1);
				c2 = swap(c2);
			}
			else
			{
				a += mod;
				b -= mod;
				c -= mod;
				d += mod;
			}
			printf("\n");
		}

		printf("\n");
		scanf("%d", &r);
	}
	while (r != 0);
}
