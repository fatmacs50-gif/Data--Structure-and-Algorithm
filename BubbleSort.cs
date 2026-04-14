#include <iostream>
using namespace std;
void bubbleSort(int arr[], int n)
{
	int c = 0; 

	for (int i = 0; i < n - 1; i++)
	{
		bool flag = true; // لو خلصت لف وهوا لسه ترو دا معناه ان المصفوفة اصلا مرتبة ومش محتاجة اعمل اي حاجة تاني

		for (int j = 0; j < n - i - 1; j++)
		{
			if (arr[j] > arr[j + 1])
			{
				swap(arr[j], arr[j + 1]);

				flag = false;
			}
			c++; // زيادة عدد المقارنات

		}

		if (flag)
		{
			break;
		}
	}

	cout << "Number of comparisons: " << c << endl;
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
	

	int arr[] = { 60, 70 , 22 ,55, 65,2};
	int n = sizeof(arr) / sizeof(arr[0]);
	bubbleSort(arr, n);
	cout << "Sorted array: \n";
	printArray(arr, n);


}


