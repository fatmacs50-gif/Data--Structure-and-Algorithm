// ConsoleApplication5.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
template <class t> // tempelet class (any data type )
class stack {

	struct Node
	{
		t item;
		Node* next;
			//Node *top * cur ;

	};
	Node* top; // pointer to the top of the stack
	Node* curr; // pointer to the current node (used for print )

	 public:stack() { // constructor
		top = NULL; // as a pointer 
	}
	void push(t newitem)
	{
		Node* newitemptr = new Node; // pointer or node =>(item , pointer (next) )
		newitemptr->item = newitem;
		newitemptr->next = top;
		top = newitemptr; // كده انا حركت البوينتر خليته يشاور علي pointer or node  اللي انا ضفتها 
	}
	bool isempty()
	{
		return top == NULL;

	}
	void pop()  //pop = > delete the top item
	{
		if (isempty())
		{
			cout << " stack empty on pop";
		}
		else
		{ // اول حاجه هعمل بيوينتر مؤقت و اخزن فيه  بيوينتر التوب 

			Node* temp = new Node;
			temp = top;
			// هحرك التوب بقي 
			top = top->next;
			temp = temp->next = NULL;
			delete temp;


		}
	}
	void pop(t& stacktop) // pop with return value
	{
		if (isempty())
		{
			cout << " stack empty on pop";
		}
		else
		{  // اول حاجه هخزن قيمه االلي هيرجعها في المتغير اللي هيرجعها
			stacktop = top->item;
			Node* temp = new Node;
			temp = top;
			// هحرك التوب بقي 
			top = top->next;
			temp = temp->next = NULL;
			delete temp;


		}
	}

	void GetTop(t& stacktop)
	{
		if (isempty())
		{
			cout << " stack empty on top";
		}
		else
		{
			stacktop = top->item;


		}
	}
	void display()
	{
		curr = top; // عشان اعرض من اول التوب
		cout << "the stack is : " ;
		cout << "[ ";
		while (curr != NULL)
		{
			cout << curr->item ;
			curr = curr->next; // عشان اعرض كل العناصر اللي في الستاك
		}
		cout << " ]";

	}

};

int main()
{

	stack<int>s; // stack of integers
	s.push(100 );
	s.push(200 );
	s.push(300 );
	s.display();




}

