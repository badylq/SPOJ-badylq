#define _CRT_SECURE_NO_WARNINGS
#include <cstdio>

int main()
{
	int n;
	scanf("%d", &n);
	double sum = 0.0;
	double max = 0.0;
	for (int i = 0; i < n; i++)
	{
		double profit;
		scanf("%lf", &profit);
		sum += profit;
		if(sum < 0.0)
		{
			sum = 0.0;
		}
		else
		{
			if(sum > max)
			{
				max = sum;
			}
		}
	}
	printf("%0.0lf\n", max);
}