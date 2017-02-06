#include <iostream>
#include <cstdio>

using namespace std;

int main()
{
	int chars[256] = { 0 };
	char c;

	while (cin.get(c))
		chars[(unsigned char)c]++;

	for (int i = 0; i < 256; ++i)
		if (chars[i] != 0)
			printf("%d %d\n", i, chars[i]);
}