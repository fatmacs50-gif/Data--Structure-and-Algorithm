
#include <iostream>
#include <vector>
#include <algorithm> 

using namespace std;


vector<long long> getRepresentation(long long n, long long base) {
    vector<long long> v;
    while (n) {
        v.push_back(n % base);
        n /= base;
    }
    reverse(v.begin(), v.end());
    return v;
}

int main() {
    long long number = 13; 
    long long base = 2;  

    cout << "Converting " << number << " to base " << base << ": " << endl;

    vector<long long> result = getRepresentation(number, base);

    for (long long digit : result) {
        cout << digit;
    }
    cout << endl;

    return 0;
}

