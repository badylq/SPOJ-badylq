#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <cstdio>

using namespace std;

int main()
{
	int tab[1000];
	int m = 0, a;
	char c;

	std::string segment;

	while (cin >> a)
	{
		tab[m] = a;
		m++;
	}
	for (int i = 0; i < m; i++)
	{
		printf("%d\n", tab[i]);
	}
	cin.get();
}