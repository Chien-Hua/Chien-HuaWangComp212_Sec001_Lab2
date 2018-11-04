using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienHuaLibrary
{
    // class to represent one node in a list
    
        class ListNode<T>
        {
            public T Data { get; private set; }
            public ListNode<T> Next { get; set; }
            public ListNode(T dataValue) : this(dataValue, null) { }
            public ListNode(T dataValue, ListNode<T> nextNode)
            {
                Data = dataValue;
                Next = nextNode;
            }
        }
        public class List<T>
        {
            private ListNode<T> firstNode;
            private ListNode<T> lastNode;
            private string name;
            public List(string listName)
            {
                name = listName;
                firstNode = lastNode = null;
            }

            public List() : this("list") { }

            public void Count()
            {
                int counter = 0;
                ListNode<T> currentNode = firstNode;
                while (currentNode != null)
                {
                    counter++;
                    currentNode = currentNode.Next;
                }
                Console.WriteLine("The number of elements in list is:" + counter + "\n");
            }

            public void Search(T insertItem)
            {
                ListNode<T> currentNode = firstNode;
                string result = "";
                while (currentNode != null)
                {
                    if (insertItem.ToString() == currentNode.Data.ToString())
                    {
                        result = string.Format("{0} is found", currentNode.Data.ToString());
                    }
                    else
                    {
                        result = string.Format("The number cannot be found {0} in the list ", insertItem);
                    }
                    currentNode = currentNode.Next;
                }
                Console.WriteLine(result + "\n");
            }
            public void Avg()
            {
                int counter = 0;
                double convertNodeToDouble = 0;
                double temp = 0;
                double result = 0;
                ListNode<T> currentNode = firstNode;
                while (currentNode != null)
                {
                    counter++;
                    double.TryParse(currentNode.Data.ToString(), out convertNodeToDouble);
                    temp += convertNodeToDouble;
                    result = temp / counter;
                    currentNode = currentNode.Next;
                }
                Console.WriteLine("The average of the list is " + result + "\n");
            }

            public void InsertAtFront(T insertItem)
            {
                if (IsEmpty())
                {
                    firstNode = lastNode = new ListNode<T>(insertItem);
                }
                else
                {
                    firstNode = new ListNode<T>(insertItem, firstNode);
                }
            }

            public void InsertAtBack(T insertItem)
            {
                if (IsEmpty())
                {
                    firstNode = lastNode = new ListNode<T>(insertItem);
                }
                else
                {
                    lastNode = lastNode.Next = new ListNode<T>(insertItem);
                }
            }

            public T RemoveFromFront()
            {
                if (IsEmpty())
                {
                    throw new EmptyListException(name);
                }

                T removeItem = firstNode.Data;
                if (firstNode == lastNode)
                {
                    firstNode = lastNode = null;
                }
                else
                {
                    firstNode = firstNode.Next;
                }

                return removeItem;
            }

            public T RemoveFromBack()
            {
                if (IsEmpty())
                {
                    throw new EmptyListException(name);
                }

                T removeItem = lastNode.Data;
                if (firstNode == lastNode)
                {
                    firstNode = lastNode = null;
                }
                else
                {
                    ListNode<T> current = firstNode;

                    while (current.Next != lastNode)
                    {
                        current = current.Next;
                    }

                    lastNode = current;
                    current.Next = null;
                }

                return removeItem;
            }

            public bool IsEmpty()
            {
                return firstNode == null;
            }

            public void Display()
            {
                if (IsEmpty())
                {
                    Console.WriteLine($"Empty {name}");
                }
                else
                {
                    Console.Write($"The {name} is: ");

                    ListNode<T> current = firstNode;

                    while (current != null)
                    {
                        Console.Write($"{current.Data} ");
                        current = current.Next;
                    }

                    Console.WriteLine("\n");
                }
            }
        }
        public class EmptyListException : Exception
        {
            public EmptyListException() : base("The list is empty") { }

            public EmptyListException(string name)
               : base($"The {name} is empty") { }

            public EmptyListException(string exception, Exception inner)
               : base(exception, inner) { }
        }
    }
