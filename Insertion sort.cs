#include <iostream>
using namespace std;
void insertionSort(int arr[], int n) // array and size 
{
	int i, key, j;            // 0  1  2  3  4  5  6 
	for (i = 1; i < n; i++)  // 80 90 60 30 50 70 40 
	{
		key = arr[i];
		j = i - 1;
		while (j >= 0 && arr[j] > key) 
		{

			// shift 

			arr[j + 1] = arr[j];  
			j = j - 1;
		}
		arr[j + 1] = key; // ده معناه انها ف مكانها الصحيح 

	}


}

void printArray(int arr[], int n)
{
	for (int i = 0; i < n; i++)
		cout << arr[i] << " ";
	cout << endl;
}

int main()
{
	int arr[] = { 80, 90, 60, 30, 50, 70, 40 };

	int n = sizeof(arr) / sizeof(arr[0]);

	insertionSort(arr, n);

	printArray(arr, n);





	return 0;
}	

