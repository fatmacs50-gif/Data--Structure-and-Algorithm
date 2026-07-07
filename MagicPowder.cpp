using namespace std;
#include <iostream>
#include<vector>
int n;
long long k;
vector <long long > a, b;
bool check(long long x)
{
	long long need = 0;
	for (int i = 0; i < n; i++)
	{
		long long required	 = a[i] - x;
		if (required >  b[i])
		{
			need += required-b[i];
		}
		if (need <= k)
		{
			return true;
		}
	}
	return false;
}

int main()
{
	cin >> n >> k;
	a.resize(n);
	b.resize(n);
	for (int i = 0; i < n; i++)
	{
		cin >> a[i];
	}
	for (int i = 0; i < n; i++)
	{
		cin >> b[i];
	}
	long  long left = 0, right = 1e18;
	long long ans = 0;
	while (left <= right)
	{
		long long mid = (left + right) / 2;
		if (check(mid))
		{
			ans = mid;
			left = mid + 1;
		}
		else
		{
			right = mid - 1;
		}
	}
   
}

