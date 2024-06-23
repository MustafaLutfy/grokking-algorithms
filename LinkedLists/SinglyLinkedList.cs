// using System;

// namespace LinkedLists
// {
//     // Node class representing a single element in the linked list
//     public class Node
//     {
//         public int Data;
//         public Node Next;

//         public Node(int data)
//         {
//             Data = data;
//             Next = null;
//         }
//     }

//     // Singly Linked List class
//     public class SinglyLinkedList
//     {
//         private Node head;

//         // Method to add a new node to the end of the list
//         public void Add(int data)
//         {
//             Node newNode = new Node(data);
//             if (head == null)
//             {
//                 head = newNode;
//             }
//             else
//             {
//                 Node current = head;
//                 while (current.Next != null)
//                 {
//                     current = current.Next;
//                 }
//                 current.Next = newNode;
//             }
//         }
//         public void AddAtBeginning(int data)
//             {
//                 Node newNode = new Node(data);
//                 newNode.Next = head;
//                 head = newNode;
//             } 
//          public void AddAtEnd(int data)
//             {
//                 Node newNode = new Node(data);
//                 if (head == null)
//                 {
//                     head = newNode;
//                 }
//                 else
//                 {
//                     Node current = head;
//                     while (current.Next != null)
//                     {
//                         current = current.Next;
//                     }
//                     current.Next = newNode;
//                 }
//             }  
//         public void InsertAt(int data, int position)
//           {
//             Node newNode = new Node(data);
//             if (position == 0)
//             {
//                 newNode.Next = head;
//                 head = newNode;
//             }
//             else
//             {
//                 Node current = head;
//                 for (int i = 0; i < position - 1 && current != null; i++)
//                 {
//                     current = current.Next;
//                 }

//                 if (current != null)
//                 {
//                     newNode.Next = current.Next;
//                     current.Next = newNode;
//                 }
//                 else
//                 {
//                     Console.WriteLine("The position is out of bounds.");
//                 }
//             }
//         }
//         // Method to display the elements of the list
//         public void Display()
//         {
//             Node current = head;
//             while (current != null)
//             {
//                 Console.Write(current.Data + " -> ");
//                 current = current.Next;
//             }
//             Console.WriteLine("null");
//         }



//          private void DisplayReverseRecursive(Node node)
//         {
//             if (node == null)
//             {
//                 return;
//             }
//             DisplayReverseRecursive(node.Next);
//             Console.Write(node.Data + " -> ");
//         }

//         // Method to display the elements of the list in reverse order
//         public void DisplayReverse()
//         {
//             DisplayReverseRecursive(head);
//             Console.WriteLine("null");
//         }

//         // Method to count the number of nodes in the list
//         public int CountNodes()
//         {
//             int count = 0;
//             Node current = head;
//             while (current != null)
//             {
//                 count++;
//                 current = current.Next;
//             }
//             return count;
//         }

//         // Method to get a node at a specific position in the list
//         public Node GetNodeAtPosition(int position)
//         {
//             if (position <= 0)
//             {
//                 throw new ArgumentException("Position must be greater than zero.");
//             }

//             Node current = head;
//             int count = 1;

//             while (current != null && count < position)
//             {
//                 current = current.Next;
//                 count++;
//             }

//             if (current == null)
//             {
//                 throw new ArgumentException("Position exceeds the length of the list.");
//             }

//             return current;
//         }

//         // Method to find the first index of a node that matches the given element
//         public int FindIndex(int element)
//         {
//             Node current = head;
//             int index = 0;

//             while (current != null)
//             {
//                 if (current.Data == element)
//                 {
//                     return index;
//                 }
//                 current = current.Next;
//                 index++;
//             }

//             // If element is not found, return -1
//             return -1;
//         }

//          public bool IsEmpty()
//         {
//             return head == null;
//         }

//          public void EmptyList()
//         {
//             head = null;
//         }
//     }

// }