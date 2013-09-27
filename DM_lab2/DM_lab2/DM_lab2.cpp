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
int *intersectionOfSets(int *A, int *B, int n, int m, int &k)
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
int *unionOfSets(int *A, int *B, int n, int m, int &k)
{
	int *mas = new int[n + m];

	k = 0;

	for (int i = 0; i < n; i++)
	{
		bool f = true;

		for (int j = 0; j < k; j++)
		{
			if (mas[j] == A[i])
				f = false;
		}

		if(f)
		{
			mas[k] = A[i];
			k++;
		}
	}

	for (int i = 0; i < m; i++)
	{
		bool f = true;

		for (int j = 0; j < k; j++)
		{
			if (mas[j] == B[i])
				f = false;
		}

		if(f)
		{
			mas[k] = B[i];
			k++;
		}
	}

	return mas;
}
int *differenceOfSets(int *A, int *B, int n, int m, int &k)
{
	int *mas = new int[n + m];

	k = 0;

	for (int i = 0; i < n; i++)
	{
		bool f = true;

		for (int j = 0; j < m; j++)
		{
			for(int l = 0; l < k; l++)
			{
				if (mas[l] == A[i])
					f = false;
			}

			if (A[i] == B[j])
				f = false;
		}

		if(f)
		{
			mas[k] = A[i];
			k++;
		}
	}

	return mas;
}
bool includedOfSets(int *A, int *B, int n, int m)
{
	if (n > m)
		return false;

	for (int i = 0; i < n; i++)
	{
		bool f = false;

		for (int j = 0; j < m; j++)
		{
			if (A[i] == B[j])
			{
				f = true;
			}
		}

		if (!f)
			return false;
	}

	return true;
}
bool equalityOfSets(int *A, int *B, int n, int m)
{
	if (n != m)
		return false;

	return includedOfSets(A, B, n, m) && includedOfSets(B, A, m, n);
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

	cout << "____________________________________________________" << endl;

	int k1, k2, k3 = 0;
	int *C = intersectionOfSets(A, B, n, m, k1);
	int *D = unionOfSets(A, B, n, m, k2);
	int *E = differenceOfSets(A, B, n, m, k3);

	sort(C, k1);
	sort(D, k2);
	sort(E, k3);

	cout << "Пересечение: ";
	print(C, k1);

	cout << "Объединение: ";
	print(D, k2);

	cout << "Разность: ";
	print(E, k3);

	cout << "____________________________________________________" << endl;

	cout << "Вхождение A в A: " << includedOfSets(A, A, n, n) << endl;
	cout << "Вхождение A в B: " << includedOfSets(A, B, n, m) << endl;
	cout << "Равенство A и B: " << equalityOfSets(A, B, n, m) << endl;
	cout << "Равенство B и B: " << equalityOfSets(B, B, m, m) << endl;

	system("Pause");
	return 0;
}

