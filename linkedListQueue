#include <iostream>
using namespace std;
class linkedListQueue
{
	struct Node
	{
		int val;
		Node* next;

	};
	Node* front, * rear;
	Node* temp;
	int length;
	Node* curr;

public:linkedListQueue()
{
	front = rear = nullptr;
	length = 0;
}

	  bool isEmpty()
	  {
		  return length == 0;
	  }
	  void Enqueue(int elemant)
	  {
		  if (isEmpty())
		  {
			  front = new Node;
			  front->val = elemant;
			  front->next = NULL;
			  rear = front;
			  length++;
		  }

		  else
		  {
			  Node* newptr = new Node;
			  newptr->val = elemant;
			  newptr->next = NULL;
			  rear->next = newptr;
			  rear = newptr;
			  length++;

		  }

	  }

	  void Dequeue()
	  {
		  if (isEmpty())
			  cout << "Queue is empty\n";
		  else
		  {
			  Node* temp = front;
			  front = front->next;
			  delete temp;
			  length--;
		  }
	  }

	  void GetFront()
	  {
		  if (isEmpty())
			  cout << "Queue is empty\n";
		  else
			  cout << "The front element is: " << front->val << endl;
	  }
	  void GetRear()
	  {
		  if (isEmpty())
			  cout << "Queue is empty\n";
		  else
			  cout << "The rear element is: " << rear->val << endl;
	  }

	  void Clear(){

		  Node* curr;
	  while (front != NULL);
	  {
		  curr = front;
		  front = front->next;
		  delete curr;

	  }
	  rear = NULL;
}
	    void display()
		{
			if (isEmpty())
				cout << "Queue is empty\n";
			else
			{
				Node* temp = front;
				cout << "Queue elements: [ ";
				while (temp != NULL)
				{
					cout << temp->val << " ";
					temp = temp->next;
				}
				cout << "]" << endl;
			}
		}


		void search(int elemant)
		{
			if (isEmpty())
				cout << "Queue is empty\n";
			else
			{
				Node* temp = front;
				while (temp != NULL)
				{
					if (temp->val == elemant)
					{
						cout << "Element found: " << temp->val << endl;
						return;
					}
					temp = temp->next;
				}
				cout << "Element not found in the queue.\n";
			}
		}

};














int main()
{ 
	  
	linkedListQueue q ;
	for (int i = -5;i < 5;i++)
	{
		q.Enqueue(10);

		q.Enqueue(20);
		q.Enqueue(30);
		q.display();
		q.Dequeue();
		q.GetFront();
		q.GetRear();
		q.search(20);
		q.Clear();

	}



}


