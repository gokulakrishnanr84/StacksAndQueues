using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Input 2.1/2.3 :: Remove duplicates from unsorted linked list :: Delete Node at Index
            /*var linkedList = new MyLinkedList();
            linkedList.AddToTail(1);
            linkedList.AddToTail(2);
            linkedList.AddToTail(3);
            linkedList.AddToTail(1);
            linkedList.AddToTail(3);
            linkedList.AddToTail(5);
            linkedList.DeleteDuplicates();
            //linkedList.DeleteIndex(3);
            //linkedList.InsertNode(4);
            //linkedList.InsertNode(4);
            linkedList.Traverse();*/
            #endregion

            #region Input 2.2 :: Find nth element to the last element
            /*var mylinkedList = new MyLinkedList();
            mylinkedList.AddToTail(1);
            mylinkedList.AddToTail(2);
            mylinkedList.AddToTail(3);
            mylinkedList.AddToTail(4);
            mylinkedList.AddToTail(5);
            var nth = mylinkedList.nthToLast(2);
            Console.WriteLine(nth != null ? nth.Value : 0);*/
            #endregion

            #region Input 2.4 :: Sum of Nodes represented as a Linked List
            /*var mylinkedList = new MyLinkedList();
            var list1 = new MyLinkedList();
            var list2 = new MyLinkedList();
            list1.AddToTail(3);
            list1.AddToTail(1);
            list1.AddToTail(5);
            list2.AddToTail(5);
            list2.AddToTail(9);
            list2.AddToTail(2);
            var sumList = mylinkedList.AddLists(list1, list2);
            sumList.Traverse();*/
            #endregion
        }
    }
    
    #region Node
    public class Node
    {
        private int _value;
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public Node(int value)
        {
            _value = value;
        }

        public Node Next;
    }
    #endregion

    public class MyLinkedList
    {        
        private Node _head;
        private Node _end;
        private Node _deleteIndex; //For Solution 2.3

        #region Solution 2.1 :: Remove duplicates from unsorted linked list :: TRY OUT WITHOUT TEMP BUFFER
        public void DeleteDuplicates()
        {
            var duplicatesDictionary = new Dictionary<int, bool>();

            var nodeD = _head;
            if (duplicatesDictionary.ContainsKey(nodeD.Value))
                _head = nodeD.Next;
            else
                duplicatesDictionary.Add(nodeD.Value, true);

            while (nodeD.Next != null)
            {
                if (duplicatesDictionary.ContainsKey(nodeD.Next.Value))
                {
                    nodeD.Next = nodeD.Next.Next;
                    if (nodeD.Next == null) //Reset the end index
                        _end = nodeD;
                    continue;
                }
                else
                {
                    duplicatesDictionary.Add(nodeD.Next.Value, true);
                }
                nodeD = nodeD.Next;
            }
        }
        #endregion

        #region Solution 2.2 :: Find nth element to the last element
        public Node nthToLast(int n)
        {
            if (_head == null)
                return null;

            var p1 = _head;
            var p2 = _head;

            for (var i = 0; i < n; i++)
            {
                if (p2 == null)
                    return null;
                p2 = p2.Next;
            }

            while(p2.Next != null)
            {
                p2 = p2.Next;
                p1 = p1.Next;
            }
            return p1;
        }
        #endregion

        #region Solution 2.3 :: Delete Node at Index
        public void DeleteIndex(int value)
        {
            var nodeD = _head;
            while (nodeD != null)
            {
                if (nodeD.Value == value)
                {
                    _deleteIndex = nodeD;
                    break;
                }
                nodeD = nodeD.Next;
            }

            if (_deleteIndex != null && _deleteIndex.Next != null)
            {
                _deleteIndex.Value = _deleteIndex.Next.Value;
                _deleteIndex.Next = _deleteIndex.Next.Next;                
            }
        }
        #endregion

        #region Solution 2.4 :: Sum of Nodes represented as a Linked List
        public MyLinkedList AddLists(MyLinkedList list1, MyLinkedList list2)
        {
            var summedUpList = new MyLinkedList();
            var carryOver = 0;
            var node1 = list1._head;
            var node2 = list2._head;
            while (node1 != null && node2 != null)
            {
                var sum = node1.Value + node2.Value + carryOver;
                carryOver = sum >= 10 ? 1 : 0;                
                summedUpList.AddToTail(new Node(sum % 10));

                node1 = node1.Next;
                node2 = node2.Next;
            }
            return summedUpList;
        }

        private Node AddNodes(Node node1, Node node2)
        {
            var sum = (node1.Value + node2.Value) % 10;
            return new Node(sum);
        }
        #endregion

        #region Add Nodes to Linked List
        public void AddToTail(int value)
        {
            var node = new Node(value);
            if (_end == null)
            {
                _end = node;
                _head = node;
            }
            else
            {
                _end.Next = node;
                _end = node;
            }
        }

        public void AddToTail(Node node)
        {
            if (_end == null)
            {
                _end = node;
                _head = node;
            }
            else
            {
                _end.Next = node;
                _end = node;
            }
        }
        #endregion

        #region Delete Node by Value
        public void DeleteNode(int value)
        {
            var nodeD = _head;
            if (nodeD == null)
                throw new Exception("Linked List is empty");

            if (nodeD.Value == value)
            {
                _head = nodeD.Next;
                return;
            }

            while(nodeD.Next != null)
            {
                if (nodeD.Next.Value == value)
                {
                    nodeD.Next = nodeD.Next.Next;
                    if (nodeD.Next == null) //Reset the end index
                        _end = nodeD;
                    return;
                }
                nodeD = nodeD.Next;
            }
        }
        #endregion

        #region Insert Node by Value
        public void InsertNode(int value)
        {
            var node = new Node(value);
            if (_head == null)
            {
                _head = node;
                _end = node;
                return;
            }

            if (_head.Value > value)
            {
                node.Next = _head;
                _head = node;
                return;
            }

            var _pointer = _head;
            while (_pointer.Next != null)
            {
                if (_pointer.Next.Value > value)
                {
                    node.Next = _pointer.Next;
                    _pointer.Next = node;
                    return;
                }
                _pointer = _pointer.Next;
            }
            _pointer.Next = node;
            _end = node;
        }
        #endregion

        #region Traverse Linked List
        public void Traverse()
        {
            var nodeT = _head;
            while(nodeT != null)
            {
                Console.WriteLine(nodeT.Value);
                nodeT = nodeT.Next;
            }
        }
        #endregion
    }
}
