// using System;

// namespace LinkedLists
// {
//     // Node class representing a single element in the linked list
//     public class Node
//     {
//         public int Data;
//         public Node Next;
//         public Node Prev;

//         public Node(int data)
//         {
//             Data = data;
//             Next = null;
//             Prev = null;
//         }
//     }

//     // Singly Linked List class
//     public class DoublyLinkedList{
//         private Node head; 
//         public void Add(int data){
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
//                     newNode.Prev = current;
//                 }
//         }
//            public void AddAtBeginning(int data)
//             {
//                 Node newNode = new Node(data);
//                 newNode.Next = head;
//                 newNode.Prev = null;
//                 head = newNode;
//             } 


//             public void InsertAt(int data, int position)
//           {
//             Node newNode = new Node(data);
//             if (position == 0)
//             {
//                 newNode.Next = head;
//                 newNode.Prev = null;
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
//                     newNode.Prev = current;
//                     current.Next = newNode;
//                 }
//                 else
//                 {
//                     Console.WriteLine("The position is out of bounds.");
//                 }
//             }
//         }

//         public void DisplayDouble()
//         {
//             Node current = head;
//             Node lastNode = null;
//             while (current.Next != null)
//             {
//                 Console.Write(current.Data + " -> ");
//                 current = current.Next;
//                 if(current.Next == null){
//                     lastNode = current.Prev;
//                 }
//             }

//             while(current != null){
//                 Console.Write(current.Data + " <- ");
//                 current = current.Prev;
//             }
//             Console.WriteLine("null");
//         }

//         public void Display()
//         {
//             Node current = head;
//             while (current.Next != null)
//             {
//                 Console.Write(current.Data + " -> ");
//                 current = current.Next;
//             }

//         }
//     }
// }