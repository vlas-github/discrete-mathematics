#include "stdafx.h"
#include <iostream>

using namespace std;

int *generate(int size)
{
	int *mas = new int[size];

	for(int i = 0; i < size; i++)
	{
		bool f = true;
		int tmp = 0;

		while (f) 
		{
			tmp = rand() % 20 + 1;
			f = false;

			for (int j = 0; j < i; j++)
			{
				if(mas[j] == tmp)
					f = true;
			}
		}

		mas[i] = tmp;
	}

	return mas;
}
int *intersection(int *A, int *B, int n, int m, int &k)
{
	int *mas = new int[n + m];

	k = 0;

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			if (A[i] == B[j])
			{
				bool f = true;

				for(int l = 0; l < k; l++)
				{
					if (mas[l] == A[i])
						f = false;
				}

				if(f)
				{
					mas[k] = A[i];
					k++;
				}
			}
		}
	}

	return mas;
}
void print(int *A, int size)
{
	cout << "( ";
	for (int i = 0; i < size; i++)
	{
		if(i == size - 1)
			cout << A[i];
		else
			cout << A[i] << ", ";
	}
	cout << " )" << endl;
}
void sort(int *A, int size)
{
	for(int i = 0; i < size - 1; i++)
	{
		for(int j = i + 1; j < size; j++)
		{
			if(A[i] > A[j])
			{
				int tmp = A[i];
				A[i] = A[j];
				A[j] = tmp;
			}
		}
	}
}

int _tmain(int argc, _TCHAR* argv[])
{
	setlocale(0, "rus");
	srand(2);

	cout << "Лабораторная работа №1" << endl 
		<< "Моделирование операции пересечения для двух множеств" << endl 
		<< "____________________________________________________" << endl;

	int n;
	int m;

	cout << "Введите размер 1-го множества: ";
	cin >> n;

	cout << "Введите размер 2-го множества: ";
	cin >> m;

	int *A = generate(n);
	int *B = generate(m);

	sort(A, n);
	sort(B, m);

	cout << "1-е множество: ";
	print(A, n);

	cout << "2-е множество: ";
	print(B, m);

	int k = 0;
	int *C = intersection(A, B, n, m, k);

	sort(C, k);

	cout << "Результирующее множество: ";
	print(C, k);

	system("Pause");
	return 0;
}

