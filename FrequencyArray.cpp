#include <iostream>
using namespace std;

int main()
{
	int arr[] = { 1, 3 ,2 , 1 , 4 ,3 , 1 };
	int n = sizeof(arr) / sizeof(arr[0]);
	int freq[5] = { 0 };  

	for (int i = 0; i < n; i++)  //  اللوب دي لحساب التكرار كل عنصر في المصفوفة arr 
	{
		freq[arr[i]]++;  
	}


	for (int i = 0; i < 5; i++) // اللوب دي لعرض العناصر والتكرار بتاعها
	{
		if (freq[i] > 0)
		{
			cout << "Element: " << i << " Frequency: " << freq[i] << endl;
		}
	}

	return 0;





}
