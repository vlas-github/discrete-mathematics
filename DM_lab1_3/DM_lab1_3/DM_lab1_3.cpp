#include "stdafx.h"
#include <iostream>

using namespace std;

void M(int mas[20][20])
{
	FILE *file;
	file = fopen("document.txt", "wt");

	for(int i = 0; i < 20; i++)
	{
		int tmp = 0;

		for(int j = 0; j < 20; j++)
		{
			tmp += mas[i][j];
			cout << mas[i][j] << " ";
			fprintf(file, "%d ", mas[i][j]);
		}

		cout << "|sum = " << tmp << endl;
		fprintf(file, "|sum = %d \n", tmp);
	}

	fclose(file);
}

int _tmain(int argc, _TCHAR* argv[])
{
	int mas[20][20];

	srand(2);

	for(int i = 0; i < 20; i++)
	{
		for(int j = 0; j < 20; j++)
		{
			mas[i][j] = rand() % 2;
		}
	}

	M(mas);

	system("Pause");
	return 0;
}

