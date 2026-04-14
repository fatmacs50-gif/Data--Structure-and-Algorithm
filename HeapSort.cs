#include <iostream>
using namespace std;
void heapify(int arr[], int n , int i )
{ 
	int max = i;
	int left = 2 * i + 1;
	int right = 2 * i + 2;
	if (left < n && arr[left] > arr[max])
	{
		max = left;
	}
	if (right < n && arr[right] > arr[max])
	{
		max = right;
	}
	if (max != i)
	{
		swap(arr[i], arr[max]);
		heapify(arr, n, max);
	}

}
void buildHeap(int arr[], int n)
{
	for (int i = n / 2 - 1; i >= 0; i--)
	{
		heapify(arr, n, i);
	}
}

void heapSort(int arr[], int n) // sorts the array in ascending order
{
	buildHeap(arr, n);
	for (int i = n - 1; i > 0; i--) // i > 0 because we are swapping the first element with the last element and then heapifying the remaining elements
	{
		swap(arr[0], arr[i]);
		heapify(arr, i, 0);
	}
}

void printArray(int arr[], int n)
{
	for (int i = 0; i < n; i++)
	{
		cout << arr[i] << " ";
	}
	cout << endl;
}
int main()
{
  

	int arr[] = { 12, 11, 13, 5, 6, 7 };
	int n = sizeof(arr) / sizeof(arr[0]);
	heapSort(arr, n);
	printArray(arr, n);


}
