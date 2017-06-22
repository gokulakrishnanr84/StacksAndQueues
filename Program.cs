using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Input 3.1 :: Single Array to implement Three Stacks
                /*var myStack = new MyStackArray(2, 3);
                myStack.Push(0, 1);
                myStack.Push(0, 2);
                myStack.Push(1, 3);
                myStack.Push(1, 4);
                myStack.Push(2, 5);
                myStack.Push(2, 6);
                Console.WriteLine(myStack.Pop(0));
                Console.WriteLine(myStack.Pop(1));
                Console.WriteLine(myStack.Pop(2));
                Console.WriteLine(myStack.Peek(0));
                Console.WriteLine(myStack.Peek(1));
                Console.WriteLine(myStack.Peek(2));*/

                /*var myStack2 = new MyStackArray2();
                myStack2.push(0, 00);
                myStack2.push(1, 10);
                myStack2.push(0, 01);
                myStack2.push(1, 11);
                myStack2.push(2, 20);
                myStack2.push(0, 02);
                myStack2.push(2, 21);
                myStack2.push(1, 12);
                myStack2.push(2, 22);

                //myStack2.pop(1);
                //Console.WriteLine(myStack2.peek(0));
                //Console.WriteLine(myStack2.peek(1));
                //Console.WriteLine(myStack2.peek(2));
                //myStack2.push(1, 13);
                //myStack2.pop(1);
                //Console.WriteLine(myStack2.peek(1));
                //Console.WriteLine(myStack2.peek(2));*/
                #endregion

                #region Input 3.2 :: Stack with Min at O(1)
                /*var myStack = new MyStackListMin();
                myStack.Push(11);
                myStack.Push(22);
                myStack.Push(13);
                myStack.Push(18);
                myStack.Push(8);
                Console.WriteLine(myStack.Min());
                myStack.Pop();
                Console.WriteLine(myStack.Min());*/
                #endregion

                #region Input 3.3 :: Set of Stacks
                /*var setOfStacks = new SetOfStacks(2);
                setOfStacks.Push(1);
                setOfStacks.Push(2);
                setOfStacks.Push(3);
                setOfStacks.Push(4);
                setOfStacks.Push(5);
                Console.WriteLine(setOfStacks.Pop());
                Console.WriteLine(setOfStacks.Pop());
                Console.WriteLine(setOfStacks.PopAt(1));
                Console.WriteLine(setOfStacks.Pop());
                Console.WriteLine(setOfStacks.Pop());
                Console.WriteLine(setOfStacks.Peek());*/
                #endregion

                #region Input 3.5 :: Implement Queue using two Stacks
                /*var myquque = new MyQueuesWithStacks();
                myquque.Enqueue(1);
                myquque.Enqueue(2);
                myquque.Enqueue(3);
                Console.WriteLine(myquque.Dequeue());
                Console.WriteLine(myquque.Dequeue());
                myquque.Enqueue(4);
                myquque.Enqueue(5);
                Console.WriteLine(myquque.Dequeue());
                Console.WriteLine(myquque.Dequeue());
                Console.WriteLine(myquque.Dequeue());
                Console.WriteLine(myquque.Dequeue());*/
                #endregion

                #region Input 3.6 :: Sort a Stack
                /*var stackOne = new Stack<int>();
                stackOne.Push(3);
                stackOne.Push(1);
                stackOne.Push(5);
                stackOne.Push(4);
                stackOne.Push(2);
                var sortedStack = new SortAStack().Sort(stackOne);
                var count = sortedStack.Count;
                for (var i = 0; i < count; i++)
                {
                    Console.WriteLine(sortedStack.Pop());
                }*/
                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

    #region Solution 3.1 :: Single Array to implement Three Stacks
    public class MyStackArray
    {
        private int[] _arr;
        private int _stackSize;
        private int _capacity;
        private int[] _stackPointer = { -1, -1, -1 };

        public MyStackArray(int stacksize, int numberOfStacks)
        {
            _stackSize = stacksize;
            _capacity = stacksize * numberOfStacks;
            _arr = new int[_capacity];
        }

        public void Push(int stackNumber, int value)
        {
            var index = (stackNumber * _stackSize) + _stackPointer[stackNumber] + 1;

            if (IsFull(stackNumber))
                throw new Exception($"Stack {stackNumber} is full");

            _arr[index] = value;
            _stackPointer[stackNumber]++;
        }

        public int Peek(int stackNumber)
        {
            if (_stackPointer[stackNumber] == -1)
                throw new Exception($"Stack {stackNumber} is empty");
            return _arr[(stackNumber * _stackSize) + _stackPointer[stackNumber]];
        }

        public int Pop(int stackNumber)
        {
            if (_stackPointer[stackNumber] == -1)
                throw new Exception($"Stack {stackNumber} is empty");

            var value = _arr[(stackNumber * _stackSize) + _stackPointer[stackNumber]];
            _stackPointer[stackNumber]--;
            return value;
        }

        private bool IsFull(int stackNumber)
        {
            return !(_stackPointer[stackNumber] < _stackSize - 1);
        }
    }

    public class MyStackArray2
    {
        static int stackSize = 3;
        int indexUsed = 0;
        int[] stackPointer = new int[] { -1, -1, -1 };

        StackNode[] buffer = new StackNode[stackSize * 3];

        public void push(int stackNum, int value)
        {
            int lastIndex = stackPointer[stackNum];
            stackPointer[stackNum] = indexUsed;
            indexUsed++;
            buffer[stackPointer[stackNum]] = new StackNode(lastIndex, value);
        }

        public int pop(int stackNum)
        {
            int value = buffer[stackPointer[stackNum]].value;
            int lastIndex = stackPointer[stackNum];
            stackPointer[stackNum] = buffer[stackPointer[stackNum]].previous;
            buffer[lastIndex] = null;
            indexUsed--;
            return value;
        }

        public int peek(int stack)
        {
            return buffer[stackPointer[stack]].value;
        }

        public bool isEmpty(int stackNum)
        {
            return stackPointer[stackNum] == -1;
        }

        class StackNode
        {
            public int previous;
            public int value;
            public StackNode(int p, int v)
            {
                value = v;
                previous = p;
            }
        }
    }
    #endregion

    #region Solution 3.2 :: Stack with Min at O(1)
    public class MyStackListMin
    {
        private Node _index;
        private Stack<int> _min = new Stack<int>();

        public void Push(int value)
        {
            var node = new Node(value);
            node.Next = _index;
            _index = node;

            if (value <= Min())
                _min.Push(value);
        }

        public int Pop()
        {
            if (_index == null)
                throw new Exception("Stack is empty");

            var value = _index.Value;
            _index = _index.Next;
            if (value == Min())
            {
                _min.Pop();
            }

            return value;
        }

        public int Peek()
        {
            if (_index == null)
                throw new Exception("Stack is empty");
            return _index.Value;
        }

        public int Min()
        {
            if (_min.Count == 0)
                return int.MaxValue;
            return _min.Peek();
        }
    }
    #endregion

    #region Solution 3.3 :: Set of Stacks :: TRY OUT THE SECOND APPROACH FOR PopAt()
    public class SetOfStacks
    {
        private List<Stack<int>> _stacks;
        private readonly int _stackCapacity;
        public SetOfStacks(int stackCapacity)
        {
            _stacks = new List<Stack<int>>();
            _stackCapacity = stackCapacity;
        }

        public void Push(int value)
        {
            var lastStack = GetLastStack();
            if (lastStack != null && lastStack.Count != _stackCapacity)
            {
                lastStack.Push(value);
            }
            else
            {
                var stack = new Stack<int>();
                stack.Push(value);
                _stacks.Add(stack);
            }
        }

        public int Pop()
        {
            if (GetLastStack() == null)
                throw new Exception("Stack is empty");

            var lastStack = GetLastStack();
            var value = lastStack.Pop();
            if (lastStack.Count == 0)
            {
                _stacks.RemoveAt(_stacks.Count - 1);
            }
            else
            {
                _stacks.RemoveAt(_stacks.Count - 1);
                _stacks.Add(lastStack);
            }

            return value;
        }

        public int PopAt(int stackAt)
        {
            var stack = GetStackAt(stackAt);
            if (stack == null)
                throw new Exception("Stack is empty");

            var value = stack.Pop();
            if (stack.Count == 0)
            {
                _stacks.RemoveAt(stackAt);
            }
            else
            {
                _stacks[stackAt] = stack;
            }
            return value;
        }

        public int Peek()
        {
            if (GetLastStack() == null)
                throw new Exception("Stack is empty");

            var lastStack = GetLastStack();
            return lastStack.Peek();
        }

        private Stack<int> GetLastStack()
        {
            if (_stacks.Count == 0)
                return null;
            return _stacks[_stacks.Count - 1];
        }

        private Stack<int> GetStackAt(int stackAt)
        {
            if (_stacks.Count == 0)
                return null;
            return _stacks[stackAt];
        }
    }
    #endregion

    #region Solution 3.5 :: Implement Queue using two Stacks
    public class MyQueuesWithStacks
    {
        private Stack<int> stackOne;
        private Stack<int> stackTwo;

        public MyQueuesWithStacks()
        {
            stackOne = new Stack<int>();
            stackTwo = new Stack<int>();
        }

        public void Enqueue(int value)
        {
            stackOne.Push(value);
        }

        public int Dequeue()
        {
            if (stackTwo.Count > 0)
                return stackTwo.Pop();

            PopulateStackTwo();
            if (stackTwo.Count == 0)
                throw new Exception("Queue is empty");

            return stackTwo.Pop();
        }

        public int Peek()
        {
            if (stackTwo.Count > 0)
                return stackTwo.Peek();

            PopulateStackTwo();
            if (stackTwo.Count == 0)
                throw new Exception("Queue is empty");

            return stackTwo.Peek();
        }

        private void PopulateStackTwo()
        {
            var count = stackOne.Count;
            for (var i = 0; i < count; i++)
            {
                stackTwo.Push(stackOne.Pop());
            }
        }
    }
    #endregion

    #region Solution 3.6 :: Sort a Stack
    public class SortAStack
    {
        public Stack<int> Sort(Stack<int> stackOne)
        {
            var stackTwo = new Stack<int>();
            while(!IsEmpty(stackOne))
            {
                var temp = stackOne.Pop();
                while(!IsEmpty(stackTwo) && stackTwo.Peek() > temp)
                {
                    stackOne.Push(stackTwo.Pop());
                }
                stackTwo.Push(temp);
            }
            return stackTwo;
        }

        private bool IsEmpty(Stack<int> stack)
        {
            return stack.Count == 0;
        }
    }
    #endregion

    #region Node
    public class Node
    {
        private int _value;
        public int Value
        {
            get { return _value; }
        }
        public Node(int value)
        {
            _value = value;
        }

        public Node Next;
    }
    #endregion

    #region My Stack Linked List Implementation
    public class MyStackList
    {
        private Node _index;

        public void Push(int value)
        {
            var node = new Node(value);
            node.Next = _index;
            _index = node;
        }

        public int Pop()
        {
            if (_index == null)
                throw new Exception("Stack is empty");

            var value = _index.Value;
            _index = _index.Next;
            return value;
        }

        public int Peek()
        {
            if (_index == null)
                throw new Exception("Stack is empty");
            return _index.Value;
        }
    }
    #endregion

    #region My Queue Linked List Implementation
    public class MyQueueList
    {
        private Node _end;
        private Node _start;

        public void Enqueue(int value)
        {
            var node = new Node(value);
            //node.Next = _start; //No need to make a circular list

            if (_end == null)
            {
                _end = node;
                _start = node;
            }
            else
            {
                _end.Next = node;
                _end = node;
            }
        }

        public int Peek()
        {
            if (_start == null)
                throw new Exception("Queue is empty");
            return _start.Value;
        }

        public int Dequeue()
        {
            if (_start == null)
                throw new Exception("Queue is empty");
            var value = _start.Value;
            _start = _start.Next;
            return value;
        }
    }
    #endregion

    #region My Stack Implementation
    public class Stack
    {
        private List<int> _stack;
        public Stack()
        {
            _stack = new List<int>();
        }

        public int Index
        {
            get { return _stack.Count - 1; }
        }
        
        public void Push(int value)
        {
            _stack.Add(value);
        }

        public int Pop()
        {
            if (Index < 0)
                throw new Exception("Stack is empty");
            var stackValue = _stack[Index];
            _stack.RemoveAt(Index);
            return stackValue;
        }

        public int Peek()
        {
            if (Index < 0)
                throw new Exception("Stack is empty");
            return _stack[Index];
        }
    }
    #endregion

    #region My Queue Implementation
    public class Queue
    {
        private int[] _queue;
        private int _capacity;
        private int _count;
        private int _start = 0;
        private int _end = 0;

        public Queue(int capacity)
        {
            _capacity = capacity;
            _queue = new int[capacity];
        }

        private bool IsFull()
        {
            return _count >= _capacity;
        }

        private bool IsEmpty()
        {
            return _count <= 0;
        }

        public void Enqueue(int value)
        {
            if (IsFull())
                throw new Exception("Queue is full");

            _queue[_end % _capacity] = value;            
            _end++;
            _count++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty");

            var queueValue = _queue[_start % _capacity];
            _start++;
            _count--;
            return queueValue;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty");

            return _queue[_start % _capacity];
        }
    }
    #endregion
}
