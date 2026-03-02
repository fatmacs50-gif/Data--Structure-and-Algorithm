#include <iostream>
#include<cassert>
using namespace std;



class CircularArrayQueue
{
	int Front;
	int Rear;
	int Length;
	int* arr;
	int MAX_SIZE;
public:	CircularArrayQueue ( int size )
	
	{
	if (size <= 0) {
		cout << "Invalid queue size. Setting to default size of 10." << endl;
		MAX_SIZE = 100; // Default size if invalid size is provided
	}
	else
	{
		MAX_SIZE = size;

	}

	Front = 0;
	Rear = MAX_SIZE - 1;
	Length = 0;
	arr = new int[MAX_SIZE];


	}




	  bool IsEmpty()
	  {
		  return Length == 0;
	  }
	   
	  bool IsFull()
	  {
		  return Length == MAX_SIZE;
	  }


	  void Enqueue(int item)
	  {
		  if (IsFull())
		  {
			  cout << "Queue is empty, adding first element." << endl;
		  }
		  else {
			  Rear = (Rear + 1) % MAX_SIZE;
			  arr[Rear] = item;

			  Length++;
		  }
		



	  }
	  void Dequeue()
	  {
		  if (IsEmpty())
		  {
			  cout << "Queue is empty, cannot dequeue." << endl;
			
		  }
		  else
		  {
			  Front = (Front + 1) % MAX_SIZE;

			  --Length;

		  }

		 


	  }
	  int  GetFront() //      ممكن نعملها بطريقه اخري ان ممكن نحتفظ بالقيمه ف متغير ونرجعها بدل ما نرجعها من المصفوفه مباشره وتبقي  pass by reference
	  {
		  assert(!IsEmpty());
		  {

			  return arr[Front];
		  }
			
		  
	  }

	  int GetRear()
	  {
		  assert(!IsEmpty());
		  
		   return arr[Rear];

		 

	  }
	  void Display()
	  {
		  if (!IsEmpty())
		  {
			  cout << "Queue elements: [ ";
			  for (int i = Front; i != Rear; i = (i + 1) % MAX_SIZE) // to loop through the queue elements until we reach the rear
			  {

				  cout << arr[i] << " ";
			  }
			  cout << arr[Rear]; // to print the last element
			  cout << " ]" << endl;
			 
		  }
		  else
		  {
			  cout << "Queue is empty, nothing to display." << endl;
		  }
	  }


	  int QueueSearch(int item)
	  {
		  int index = -1; // Initialize index to -1 to indicate not found
		  if (!IsEmpty())
		  {
			  for (int i = Front; i != Rear; i = (i + 1) % MAX_SIZE)
			  {
				  if (arr[i] == item)
				  {
					  index=i;
					  break;// Return the index of the found item
				  }
			  }
			  if (index == -1 && arr[Rear] == item) // Check the rear element separately
			  {
				  index = Rear;
			  }
			  else
			  {
				  cout << "  This value is not valid   " << endl;
				  return index; 

			  }
		  }
		  return -1; // Item not found
	  }


	  ~CircularArrayQueue()
	  {
		  delete[]arr;
  }


};



int main()
{

	CircularArrayQueue Q (5);
	Q.Enqueue(10);
	Q.Enqueue(15);
	Q.Enqueue(23);
	Q.Enqueue(20);
	Q.Enqueue(90);
	Q.Dequeue();
	Q.GetFront();
	Q.GetRear();
	Q.QueueSearch(4);

	Q.Display();







   
}
