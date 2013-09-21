#include "stdafx.h"
#include <iostream>

using namespace std;

int sign(int x) 
{
	if(x < 0)
		return -1;
	if (x == 0)
		return 0;
	if (x > 0)
		return 1;
}

int _tmain(int argc, _TCHAR* argv[])
{
	setlocale(0, "rus");
	int x;

	cout << "¬ведите x: ";
	cin >> x;
	
	cout << "x    = " << x << endl 
		 << "sign = " << sign(x) << endl;

	system("Pause");
	return 0;
}



