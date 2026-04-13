#include <iostream>
#include <algorithm>
using namespace std;
void Selectionsort(int arr[], int n)
{
	int min_index;
	for (int i = 0; i < n - 1; i++)
	{
		int min_index = i;
		for (int j = i + 1; j < n; j++)
		{
			if (arr[j] < arr[min_index])
			{
				min_index = j;
			
			}
			
		}
		swap(arr[min_index], arr[i]);
	}
}

void printarray(int arr[], int n)
{
	for (int i = 0; i < n; i++)
	{
		cout << arr[i] << " ";

	}
}
int main()
{

	int arr[] = { 64, 25, 12, 22, 11 };
	int n = sizeof(arr)/sizeof(arr[0]);
	Selectionsort(arr, n);
	cout << "Sorted array: \n";
	printarray(arr, n);
	cout << endl;
   
}


