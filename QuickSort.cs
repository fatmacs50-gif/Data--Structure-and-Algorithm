#include <iostream>
using namespace std;
int  partitoion1(int arr[], int l, int h ) //   pivot دي بتجيب 
{
	int pivot = arr[l];
	int i = l;
	int j = h; 
	while (i < j)
	{       do
		{
			i++;
		} 
	while (arr[i] <= pivot); // طول ماالمحور كبير  استمر في الزيادة

		do
		{
			j--;
		} while (arr[j] > pivot);

		if (i < j) // طالما i اصغر من j  استمر في التبديل
		{
			swap(arr[i], arr[j]);
		}
	}

	swap(arr[l], arr[j]); // احل مكان المحور مع المكان الذي توقف عنده j  ليكون المحور في مكانه الصحيح
		return j;


}

void quickSort(int arr[], int l, int h)
{
	if (l < h) // دا معناه ان في اكتر من عنصرين في المصفوفة  يعني لسه في حاجة تتقسم
	{
		int p = partitoion1(arr, l, h);
		quickSort(arr, l, p-1);
		quickSort(arr, p + 1, h);
	}
}



int main()
{
	int arr[] = { 10, 80, 30, 90, 40, 50, 70 };
	int n = sizeof(arr) / sizeof(arr[0]);

	quickSort(arr, 0, n);

	for (int i = 0; i < n; i++)
	{
		cout << arr[i] << " ";
	}
	cout << endl;




   
}
