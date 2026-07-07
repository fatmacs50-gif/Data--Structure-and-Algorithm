using namespace std;
#include <iostream>


int main()
{
    int arr[10] = { 1,2,3,4,5,6,7,8,9,10 };
    int target = 5;

    int left = 0;
    int right = 9;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (arr[mid] == target)
        {
            cout << "Found it at index " << mid;
            return 0;
        }
        else if (arr[mid] < target)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    cout << "Not Found";
}
