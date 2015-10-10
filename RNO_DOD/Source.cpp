#define _CRT_SECURE_NO_WARNINGS

#include <cstdio>

using namespace std;

int main()
{
	int n, t, a, sum;
	scanf("%d", &n);
	for (int i = 0; i < n; i++)
	{
		scanf("%d", &t);
		sum = 0;
		for (int i = 0; i < t; i++)
		{
			scanf("%d", &a);
			sum += a;
		}
		printf("%d\n", sum);
	}
}