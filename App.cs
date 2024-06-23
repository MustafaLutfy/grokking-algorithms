using LinkedLists;
public class App
{
    public static void Main(string[] args)
    {

        // |##########################################################################|
        // |Remove the comment under each Question to run it's code using (dotnet run)|
        // |The functional code in other files we are here running and testing only   |  
        // |##########################################################################|


        //Chaper One Realated Problems
        
        // Console.WriteLine(numOfSteps.CountSteps());
        // Console.WriteLine(SearchAlgorithems.BinarySearch(7));




        //Linked List Problems from the document

        // Q1/ Display Linked List in normal order
        // //Adding elements to the list
        // list.Add(1);
        // list.Add(2);
        // list.Add(3);
        // list.Add(4);
        // list.Add(5);

        // // Displaying the elements of the list
        // list.Display();




        // Q2/Input n number of elements and display Linked List in reverse order

        // LinkedLists.SinglyLinkedList list = new SinglyLinkedList();
        //     Console.Write("Enter the number of nodes: ");
        //     int n = int.Parse(Console.ReadLine());
        //     for (int i = 1; i <= n; i++)
        //     {
        //         Console.Write($"Enter data for node {i}: ");
        //         int data = int.Parse(Console.ReadLine());
        //         list.Add(data);
        //     }
        //     // Displaying the elements of the list in reverse order
        //     Console.WriteLine("The list in reverse order is:");
        //     list.DisplayReverse();




            // Q3/ Input n number of elements and display Linked List with count of elements

            // LinkedLists.SinglyLinkedList list = new SinglyLinkedList();
            // Console.Write("Enter the number of nodes: ");
            // int n = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= n; i++)
            // {
            //     Console.Write($"Enter data for node {i}: ");
            //     int data = int.Parse(Console.ReadLine());
            //     list.Add(data);
            // }
            // // Displaying the elements of the list
            // Console.WriteLine("The list is:");
            // list.Display();
            // // Counting the number of nodes
            // int nodeCount = list.CountNodes();
            // Console.WriteLine($"The number of nodes in the list is: {nodeCount}");



            // Q4/ Input n number of elements and display Linked List 
            //     Then Choose data to input and what position to insert in

            // LinkedLists.SinglyLinkedList list = new SinglyLinkedList();
            // Console.Write("Enter the number of nodes: ");
            // int n = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= n; i++)
            // {
            //     Console.Write($"Enter data for node {i}: ");
            //     int data = int.Parse(Console.ReadLine());
            //     list.Add(data);
            // }
            // Console.WriteLine("The list is:");
            // list.Display();
            // Console.Write("Enter the data to insert: ");
            // int insertData = int.Parse(Console.ReadLine());
            // Console.Write("Enter the position to insert the node: ");
            // int position = int.Parse(Console.ReadLine());
            // list.InsertAt(insertData, position);
            // Console.WriteLine("The list after insertion is:");
            // list.Display();
        

            // Q5/ Input n number of elements and insert elements at the beginning of a Linked List 
            //  LinkedLists.SinglyLinkedList list = new SinglyLinkedList();
            // Console.Write("Enter the number of nodes: ");
            // int n = int.Parse(Console.ReadLine());

            // for (int i = 1; i <= n; i++)
            // {
            //     Console.Write($"Enter data for node {i}: ");
            //     int data = int.Parse(Console.ReadLine());
            //     list.AddAtBeginning(data);
            // }

            // // Displaying the elements of the list
            // Console.WriteLine("The list is:");
            // list.Display();




            // Q6/ Input n number of elements and insert elements at the end of a Linked List 
            //  LinkedLists.SinglyLinkedList list = new SinglyLinkedList();
            //  Console.Write("Enter the number of nodes: ");
            // int n = int.Parse(Console.ReadLine());

            // for (int i = 1; i <= n; i++)
            // {
            //     Console.Write($"Enter data for node {i}: ");
            //     int data = int.Parse(Console.ReadLine());
            //     list.AddAtEnd(data);
            // }

            // // Displaying the elements of the list
            // Console.WriteLine("The list is:");
            // list.Display();

            // Q7/ get a node in an existing singly linked list by it's position entered by the user
            //  LinkedLists.SinglyLinkedList list = new SinglyLinkedList();
            // list.AddAtEnd(10);
            // list.AddAtEnd(20);
            // list.AddAtEnd(30);
            // list.AddAtEnd(40);
            // list.AddAtEnd(50);

            // // Displaying the elements of the list
            // Console.WriteLine("The list is:");
            // list.Display();

            // // Getting a node at position 3 (index-based)
            // Console.WriteLine("Enter the node you want it's value:");
            // int position = int.Parse(Console.ReadLine());
            // try
            // {
            //     Node node = list.GetNodeAtPosition(position);
            //     Console.WriteLine($"Node at position {position}: {node.Data}");
            // }
            // catch (ArgumentException ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }



            // Q8/ find the first index that matches a given element. Return -1 for no matching.

            // LinkedLists.SinglyLinkedList list = new SinglyLinkedList();
            // list.AddAtEnd(10);
            // list.AddAtEnd(20);
            // list.AddAtEnd(30);
            // list.AddAtEnd(40);
            // list.AddAtEnd(50);

            // // Displaying the elements of the list
            // Console.WriteLine("The list is:");
            // list.Display();

            // // Finding the index of element
            // Console.WriteLine("Enter the node you want to get it's index:");
            // int elementToFind = int.Parse(Console.ReadLine());
            // int index = list.FindIndex(elementToFind);

            // if (index != -1)
            // {
            //     Console.WriteLine($"The index of {elementToFind}: {index}");
            // }
            // else
            // {
            //     Console.WriteLine($"{elementToFind} not found in the list.");
            // }


            // Q9/ check whether a single linked list is empty or not. Return true otherwise false
            
            // LinkedLists.SinglyLinkedList list = new SinglyLinkedList();
            //  // Check if list is empty initially
            // Console.WriteLine($"Is list empty: {list.IsEmpty()}");

            // // Adding nodes to the list
            // list.AddAtEnd(10);
            // list.AddAtEnd(20);
            // list.AddAtEnd(30);

            // // Displaying the elements of the list
            // Console.WriteLine("The list is:");
            // list.Display();

            // // Check if list is empty after adding nodes
            // Console.WriteLine($"Is list empty: {list.IsEmpty()}");


            // Q10/ empty a singly linked list by pointing the head towards null.
            
            // LinkedLists.SinglyLinkedList list = new SinglyLinkedList();
            //   list.AddAtEnd(10);
            // list.AddAtEnd(20);
            // list.AddAtEnd(30);

            // // Displaying the elements of the list
            // Console.WriteLine("The list is:");
            // list.Display();

            // // Emptying the list
            // list.EmptyList();
            // Console.WriteLine("After emptying the list:");
            // list.Display();

            // // Check if list is empty after emptying
            // Console.WriteLine($"Is list empty: {list.IsEmpty()}");










            // LinkedLists.DoublyLinkedList list = new DoublyLinkedList();
            //   list.Add(10);
            //   list.Add(20);
            //   list.Add(30);

            // // Displaying the elements of the list
            // Console.WriteLine("The list is:");
            // list.DisplayDouble();



            // LinkedLists.DoublyLinkedList list = new DoublyLinkedList();
            //   list.AddAtBeginning(10);
            //   list.AddAtBeginning(20);
            //   list.AddAtBeginning(30);

            // // Displaying the elements of the list
            // Console.WriteLine("The list is:");
            // list.DisplayDouble();




            // LinkedLists.DoublyLinkedList list = new DoublyLinkedList();
            // Console.Write("Enter the number of nodes: ");
            // int n = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= n; i++)
            // {
            //     Console.Write($"Enter data for node {i}: ");
            //     int data = int.Parse(Console.ReadLine());
            //     list.Add(data);
            // }
            // Console.WriteLine("The list is:");
            // list.Display();
            // Console.Write("Enter the data to insert: ");
            // int insertData = int.Parse(Console.ReadLine());
            // Console.Write("Enter the position to insert the node: ");
            // int position = int.Parse(Console.ReadLine());
            // list.InsertAt(insertData, position);
            // Console.WriteLine("The list after insertion is:");
            // list.Display();
    }
}

