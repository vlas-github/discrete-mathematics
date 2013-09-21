#include "stdafx.h"
#include <iostream>

using namespace std;

float f(float x) 
{
	return x*x + 1;
}

int _tmain(int argc, _TCHAR* argv[])
{
	float a, b, h;

	cout << "input a: ";
	cin >> a;

	cout << "input b: ";
	cin >> b;

	cout << "input h: ";
	cin >> h;

	FILE *file;


	file = fopen("document.txt", "wt");

	cout << "x = " << a << " | f(x) = " << f(a) << endl;

	while (a < b)
	{
		a += h;
		fprintf(file, "%f \n", f(a));
		cout << "x = " << a << " | f(x) = " << f(a) << endl;
	}


	fclose(file);

	system("pause");
	return 0;
}

