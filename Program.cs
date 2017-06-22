using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreesAndGraphs
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Populate Binary Tree
            var tree = new BinaryTree(50);
            tree.Root.Left = new BinaryNode(10);
            tree.Root.Right = new BinaryNode(60);
            tree.Root.Left.Left = new BinaryNode(5);
            tree.Root.Left.Right = new BinaryNode(20);
            tree.Root.Right.Left = new BinaryNode(55);
            tree.Root.Right.Left.Left = new BinaryNode(45);
            tree.Root.Right.Right = new BinaryNode(70);
            tree.Root.Right.Right.Left = new BinaryNode(65);
            tree.Root.Right.Right.Right = new BinaryNode(80);

            /*tree.InsertIntoBST(4);
            tree.InsertIntoBST(2);
            tree.InsertIntoBST(6);
            tree.InsertIntoBST(5);
            tree.InsertIntoBST(7);
            tree.InsertIntoBST(3);
            tree.InsertIntoBST(1);*/
            //tree.PrintBSTGivenRange(tree.Root, 3, 6);
            //tree.KthSmallestElement(tree.Root, 0, 3);
            //tree.InOrderTraversal(tree.Root);
            //tree.ReverseInOrder();
            //var pre = new int[] { 20, 10, 11, 13, 12 };
            //Console.WriteLine(tree.HasOnlyOneChild(pre, pre.Length));
            Console.WriteLine(tree.LargestBST());

            //var arr = new int[] { 6, -13, -8, 7, 13, 14, 15 };
            //Console.WriteLine(tree.IsTripletPresent(arr));
            #endregion

            #region Populate DLL
            /*var dll = new DLL();
            dll.AddNode(1);
            dll.AddNode(2);
            dll.AddNode(3);
            dll.AddNode(4);
            dll.AddNode(5);*/
            //Console.WriteLine(dll.RootValue());
            //dll.PrintNodes();
            #endregion

            #region Sorted Array to BST
            //var sortedArray = new int[] { 11, 12, 13, 14, 15, 16, 17 };
            //var sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //tree.SortedArrayToBST(sortedArray, 0, sortedArray.Length - 1);
            //tree.InOrderTraversal(tree.Root);
            #endregion

            #region Input
            //var inOrderPredecessor = tree.InOrderPredecessor(tree.Root, new BinaryNode(7), null);
            //Console.WriteLine(inOrderPredecessor != null ? inOrderPredecessor.Value : -1);

            /*var inOrderSuccessor = tree.InOrderSuccessor(tree.Root, new BinaryNode(1), null);
            Console.WriteLine(inOrderSuccessor != null ? inOrderSuccessor.Value : -1);
            inOrderSuccessor = tree.InOrderSuccessor(tree.Root, new BinaryNode(2), null);
            Console.WriteLine(inOrderSuccessor != null ? inOrderSuccessor.Value : -1);
            inOrderSuccessor = tree.InOrderSuccessor(tree.Root, new BinaryNode(3), null);
            Console.WriteLine(inOrderSuccessor != null ? inOrderSuccessor.Value : -1);
            inOrderSuccessor = tree.InOrderSuccessor(tree.Root, new BinaryNode(4), null);
            Console.WriteLine(inOrderSuccessor != null ? inOrderSuccessor.Value : -1);
            inOrderSuccessor = tree.InOrderSuccessor(tree.Root, new BinaryNode(5), null);
            Console.WriteLine(inOrderSuccessor != null ? inOrderSuccessor.Value : -1);
            inOrderSuccessor = tree.InOrderSuccessor(tree.Root, new BinaryNode(6), null);
            Console.WriteLine(inOrderSuccessor != null ? inOrderSuccessor.Value : -1);
            inOrderSuccessor = tree.InOrderSuccessor(tree.Root, new BinaryNode(7), null);
            Console.WriteLine(inOrderSuccessor != null ? inOrderSuccessor.Value : -1);
            inOrderSuccessor = tree.InOrderSuccessor(tree.Root, null, null);
            Console.WriteLine(inOrderSuccessor != null ? inOrderSuccessor.Value : -1);
            inOrderSuccessor = tree.InOrderSuccessor(tree.Root, new BinaryNode(8), null);
            Console.WriteLine(inOrderSuccessor != null ? inOrderSuccessor.Value : -1);*/

            //var tree1 = new BinaryTree(4);
            //tree1.Root.Left = new BinaryNode(2);
            //tree1.Root.Left.Left = new BinaryNode(1);
            //tree1.Root.Left.Right = new BinaryNode(4);
            //tree1.Root.Right = new BinaryNode(16);
            //tree1.Root.Right.Left = new BinaryNode(15);
            //tree1.Root.Right.Right = new BinaryNode(17);
            //tree1.Root.Right.Left = new BinaryNode(5);
            //tree1.Root.Right.Right = new BinaryNode(8);
            //tree1.Root.Right.Right.Right = new BinaryNode(7);
            //Console.WriteLine(tree1.IsBinarySearchTree());

            //tree.InOrderTraversal(tree.Root);
            //Console.WriteLine(tree.HeightOfBT());
            //tree.LevelOrderTraversal();
            //Console.WriteLine("LCA is {0}", tree.FindLCA(2, 3));
            //Console.WriteLine("Distance between nodes is {0}", tree.DistanceBetweenNodes(2, 6));
            //Console.WriteLine("Distance between nodes is {0}", tree.DistanceBetweenNodes(1, 7));
            //Console.WriteLine("Distance between nodes is {0}", tree.DistanceBetweenNodes(1, 8));

            /*Console.WriteLine(tree.FindNode(4));
            Console.WriteLine(tree.FindNode(6));
            Console.WriteLine(tree.FindNode(7));
            Console.WriteLine(tree.FindNode(8));*/

            /*var tree = new BinaryTree(1);
            var root = tree.Root;
            root.Left = new BinaryNode(2);
            root.Left.Left = new BinaryNode(4);
            root.Left.Left.Left = new BinaryNode(8);
            root.Left.Left.Right = new BinaryNode(9);
            root.Left.Right = new BinaryNode(5);

            root.Right = new BinaryNode(3);
            root.Right.Left = new BinaryNode(6);
            root.Right.Right = new BinaryNode(7);
            root.Right.Right.Left = new BinaryNode(10);
            root.Right.Right.Right = new BinaryNode(11);

            tree.PreOrderTraversal(root);
            Console.WriteLine();
            tree.InOrderTraversal(root);
            Console.WriteLine();
            tree.PostOrderTraversal(root);
            Console.WriteLine();*/
            #endregion

            /*var arr1 = new int[] { -14, -8, 6, 7, 13, 14, 15 };
            var bigO = 0;
            Console.WriteLine(Trial.BruteForce(arr1, ref bigO));
            Console.WriteLine(bigO);*/
        }
    }

    public class Trial
    {
        public static bool BruteForce(int[] arr, ref int bigO)
        {
            if (arr == null)
                return false;

            var length = arr.Length;
            for (var i = 0; i < length; i++)
            {
                for (var j = i+1; j < length; j++)
                {
                    for (var k = j+1; k < length; k++)
                    {
                        bigO += 1;
                        var calculatedSum = arr[i] + arr[j] + arr[k];
                        if (calculatedSum == 0)
                            return true;
                    }
                }
            }
            return false;
        }
    }

    #region Binary Tree
    public class BinaryTree
    {
        #region Initial Variables
        private BinaryNode _root;
        private int _height;
        public BinaryNode Root { get { return _root; } }

        //Below variables for calculating distance between two nodes
        private bool n1, n2 = false;
        private int lcaLevel;
        private int d1, d2 = -1;

        public BinaryTree()
        {

        }
        public BinaryTree(int value)
        {
            _root = new BinaryNode(value);
        }
        #endregion

        #region 1. InOrderSuccessor of BST
        public BinaryNode InOrderSuccessor(BinaryNode root, BinaryNode node, BinaryNode successor)
        {
            if (root == null || node == null)
            {
                return successor;
            }

            if (root.Value == node.Value)
            {
                if (root.Right != null)
                {
                    root = root.Right;
                    while(root.Left != null)
                    {
                        root = root.Left;
                    }
                    return root;
                }
                return successor;
            }

            if (root.Value > node.Value)
                return InOrderSuccessor(root.Left, node, root);
            else if (root.Value < node.Value)
                return InOrderSuccessor(root.Right, node, successor);
            else
                return null;
        }
        #endregion

        #region 1.1. InOrderPredecessor of BST
        public BinaryNode InOrderPredecessor(BinaryNode root, BinaryNode node, BinaryNode predecessor)
        {
            if (root == null || node == null)
            {
                return predecessor;
            }

            if (root.Value == node.Value)
            {
                if (root.Left != null)
                {
                    while (root.Left != null)
                    {
                        root = root.Left;
                    }
                    return root;
                }
                return predecessor;
            }

            if (root.Value > node.Value)
                return InOrderPredecessor(root.Left, node, predecessor);
            else if (root.Value < node.Value)
                return InOrderPredecessor(root.Right, node, root);
            else
                return null;
        }
        #endregion

        #region 2. PreOrderTraversal
        public void PreOrderTraversal(BinaryNode node)
        {
            if (node == null)
                return;
            Console.Write(node.Value + " ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }
        #endregion

        #region 3. InOrderTraversal
        public void InOrderTraversal(BinaryNode node)
        {
            if (node == null)
                return;
            InOrderTraversal(node.Left);
            Console.Write(node.Value + " ");
            InOrderTraversal(node.Right);
        }
        #endregion

        #region 3.1. Print BST in a Given Range
        public void PrintBSTGivenRange(BinaryNode node, int k1, int k2)
        {
            if (node == null)
                return;

            if (node.Value > k1)
                PrintBSTGivenRange(node.Left, k1, k2);

            if (node.Value >= k1 && node.Value <= k2)
                Console.WriteLine(node.Value);

            if (node.Value < k2)
                PrintBSTGivenRange(node.Right, k1, k2);
        }
        #endregion

        #region 4. PostOrderTraversal
        public void PostOrderTraversal(BinaryNode node)
        {
            if (node == null)
                return;
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Value + " ");
        }
        #endregion

        #region 5. LevelOrderTraversal
        public void LevelOrderTraversal()
        {
            var level = HeightOfBT();
            for (var i = 0; i < level; i++)
            {
                LevelTraversal(_root, i, 0);
            }
        }

        private void LevelTraversal(BinaryNode node, int printLevel, int currentLevel)
        {
            if (node == null)
                return;

            if (printLevel == currentLevel)
            {
                Console.Write(node.Value + " ");
                return;
            }
            LevelTraversal(node.Left, printLevel, currentLevel + 1);
            LevelTraversal(node.Right, printLevel, currentLevel + 1);
        }
        #endregion

        #region 6. Insert Into BST
        public void InsertIntoBST(int value)
        {
            _root = InsertIntoBST(_root, value);
        }

        private BinaryNode InsertIntoBST(BinaryNode node, int value)
        {
            if (node == null)
            {
                node = new BinaryNode(value);
                return node;
            }
            if (value > node.Value)
                node.Right = InsertIntoBST(node.Right, value);
            else
                node.Left = InsertIntoBST(node.Left, value);
            return node;
        }
        #endregion

        #region 7. Height of BST
        public int HeightOfBT()
        {
            if (_height != 0)
                return _height;

            _height = HeightOfBT(_root);
            return _height;
        }

        private int HeightOfBT(BinaryNode node)
        {
            if (node == null)
                return 0;

            var lHeight = HeightOfBT(node.Left);
            var rHeight = HeightOfBT(node.Right);
            return lHeight > rHeight ? lHeight + 1 : rHeight + 1;
        }
        #endregion

        #region 8. Find a Node - Level in the Binary Tree
        public int FindNode(int toFind)
        {
            return FindNode(_root, 0, toFind);
        }

        private int FindNode(BinaryNode node, int level, int toFind)
        {
            if (node == null)
                return -1;

            if (node.Value == toFind)
                return level;

            var nodeLevel = FindNode(node.Left, level + 1, toFind);
            if (nodeLevel == -1)
                nodeLevel = FindNode(node.Right, level + 1, toFind);
            return nodeLevel;
        }
        #endregion

        #region 9. Find LCA in Binary Tree
        public int FindLCA(int node1, int node2)
        {
            n1 = false;
            n2 = false;
            lcaLevel = 0;

            var lca = FindLCA(_root, node1, node2, lcaLevel);
            //if (n1 && n2)
            if (lca != null)
            {
                //Console.WriteLine("LCA distance from root is {0}", lcaLevel);
                return lca.Value;
            }

            return -1;
        }

        private BinaryNode FindLCA(BinaryNode root, int node1, int node2, int level)
        {
            if (root == null)
            {
                level = -1;
                return null;
            }

            if (node1 == root.Value)
            {
                n1 = true;
                lcaLevel = level;
                return root;
            }
            if (node2 == root.Value)
            {
                n2 = true;
                lcaLevel = level;
                return root;
            }

            var leftLCA = FindLCA(root.Left, node1, node2, level + 1);
            var rightLCA = FindLCA(root.Right, node1, node2, level + 1);

            if (leftLCA != null && rightLCA != null)
            {
                lcaLevel = level;
                return root;
            }

            return leftLCA != null ? leftLCA : rightLCA;
        }
        #endregion

        #region 10. Find LCA in BST
        public int FindLCAInBST(int node1, int node2)
        {
            var lca = FindLCAInBST(_root, node1, node2);
            if (lca == null)
                return -1;
            else return lca.Value;
        }

        private BinaryNode FindLCAInBST(BinaryNode node, int node1, int node2)
        {
            if (node == null)
                return null;

            if (node.Value > node1 && node.Value > node2)
                return FindLCAInBST(node.Left, node1, node2);

            if (node.Value < node1 && node.Value < node2)
                return FindLCAInBST(node.Right, node1, node2);

            return node;
        }
        #endregion

        #region 11. Distance Between Nodes
        public int DistanceBetweenNodes(int node1, int node2)
        {
            //APPROACH 1
            //Find Node1 distance from Root
            //Find Node2 distance from Root
            //Find LCA distance from Root
            //Distance between nodes ::: D1 + D2 - (2 * DLCA)
            /*var d1 = FindNode(_root, 0, node1);
            var d2 = FindNode(_root, 0, node2);
            var lca = FindLCA(node1, node2);

            if (d1 == -1 || d2 == -1)
                return -1;

            return d1 + d2 - (2 * lcaLevel);*/

            //APPROACH 2
            //Similar to above approach but instead of 3 separate calls to find the distance, find D1 or D2 or Both during DLCA calculation
            d1 = -1;
            d2 = -1;
            var dLCA = FindLCADistance(_root, node1, node2, lcaLevel);

            if (dLCA == -1)
                return -1;

            if (d1 == -1)
                d1 = FindNode(_root, 0, node1);

            if (d2 == -1)
                d2 = FindNode(_root, 0, node2);

            if (d1 == -1 || d2 == -1)
                return -1;

            return d1 + d2 - (2 * dLCA);
        }

        public int FindLCADistance(int node1, int node2)
        {
            lcaLevel = 0;
            return FindLCADistance(_root, node1, node2, lcaLevel);
        }

        private int FindLCADistance(BinaryNode root, int node1, int node2, int level)
        {
            if (root == null)
            {
                //d1 = -1;
                //d2 = -1;
                return -1;
            }
            if (root.Value == node1)
            {
                d1 = level;
                return level;
            }
            if (root.Value == node2)
            {
                d2 = level;
                return level;
            }

            var lDLCA = FindLCADistance(root.Left, node1, node2, level + 1);
            var rDLCA = FindLCADistance(root.Right, node1, node2, level + 1);

            if (lDLCA != -1 && rDLCA != -1)
            {
                return level;
            }

            return lDLCA != -1 ? lDLCA : rDLCA;
        }
        #endregion

        #region 12. Is Given Tree a BST
        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(_root, int.MinValue, int.MaxValue);
        }

        private bool IsBinarySearchTree(BinaryNode node, int min, int max)
        {
            if (node == null)
                return true;

            if (node.Value < min || node.Value > max)
                return false;

            var lNode = false;
            var rNode = false;
            lNode = IsBinarySearchTree(node.Left, min, node.Value - 1);
            if (lNode) // Avoid calling the right node if left node is already false
            {
                rNode = IsBinarySearchTree(node.Right, node.Value + 1, max);
            }

            return lNode && rNode;
        }
        #endregion

        #region 13. Kth Smallest element in BST
        public int KthSmallestElement(BinaryNode root, int level, int k)
        {
            Console.WriteLine("Level " + level);
            if (root == null)
                return level;

            if (level < k)
            {
                level = KthSmallestElement(root.Left, level, k) + 1;
            }
            if (level == k)
            {
                Console.WriteLine(root.Value);
            }
            if (level < k)
            {
                level = KthSmallestElement(root.Right, level, k);
            }
            return level;
        }
        #endregion

        #region 14. Sorted Array to BST
        public void SortedArrayToBST(int[] arr, int min, int max)
        {
            if (min > max)
                return;

            var mid = min + ((max - min) / 2);
            InsertIntoBST(arr[mid]);
            SortedArrayToBST(arr, min, mid - 1);
            SortedArrayToBST(arr, mid + 1, max);
            return;
        }
        #endregion

        #region 15. Largest BST
        public int LargestBST()
        {
            var largestBST = LargestBST(_root);
            if (largestBST != null)
                return largestBST.Height;
            return 0;
        }

        private BST LargestBST(BinaryNode node)
        {
            if (node == null)
            {
                return null;
            }

            var left = LargestBST(node.Left);
            var right = LargestBST(node.Right);
            if (left == null && right == null)
            {
                return new BST
                {
                    HighestLeft = node.Value,
                    LowestRight = node.Value,
                    Height = 1
                };
            }
            else if (node.Value > left.HighestLeft && node.Value < right.LowestRight)
            {
                return new BST
                {
                    HighestLeft = node.Left.Value > right.LowestRight ? node.Left.Value : right.LowestRight,
                    LowestRight = node.Right.Value < left.HighestLeft ? node.Right.Value : left.HighestLeft,
                    //HighestLeft = left.HighestLeft > right.LowestRight ? left.HighestLeft : right.LowestRight,
                    //LowestRight = left.HighestLeft < right.LowestRight ? left.HighestLeft : right.LowestRight,
                    Height = left.Height + right.Height + 1
                };
            }

            if (node.Value > left.HighestLeft)
            {
                return new BST
                {
                    Height = left.Height
                };
            }

            if (node.Value < right.LowestRight)
            {
                return new BST
                {
                    Height = right.Height
                };
            }
            return null;
        }
        #endregion

        #region 16. Add greater values to every given node - Reverse PreOrder Traversal
        public void ReverseInOrder()
        {
            var add = 0;
            ReverseInOrder(_root, ref add);
        }

        private void ReverseInOrder(BinaryNode node, ref int add)
        {
            if (node == null)
            {
                return;
            }

            ReverseInOrder(node.Right, ref add);
            add += node.Value;
            Console.WriteLine(add);            
            ReverseInOrder(node.Left, ref add);
        }
        #endregion

        #region 17. Has internal node has only one child?
        public bool HasOnlyOneChild(int[] preOrderArray, int length)
        {
            int nextDifference = 0, lastDifference = 0;
            for (var i = 0; i < length - 2; i++)
            {
                nextDifference = preOrderArray[i] - preOrderArray[i+1];
                lastDifference = preOrderArray[i] - preOrderArray[length - 1];
                if(nextDifference * lastDifference < 0)
                    return false;
            }
            return true;
        }
        #endregion

        #region 18. Is Triplet Present?
        Dictionary<int, bool> tripletDict = new Dictionary<int, bool>();
        public bool IsTripletPresent(int[] arr)
        {
            if (arr == null || arr.Length < 3)
                return false;

            foreach(var i in arr)
            {
                tripletDict.Add(i, true);
            }

            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    var element = arr[i] + arr[j];
                    if (tripletDict.ContainsKey(-element))
                        return true;
                }
            }
            return false;
        }
        #endregion
    }
    #endregion

    #region Doubly Linked List
    public class DLL
    {
        private Node _root;

        public void AddNode(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                return;
            }

            var node = _root;
            while(node.Next != null)
            {
                node = node.Next;
            }
            node.Next = new Node(value);
            node.Next.Prev = node;
        }

        public int RootValue()
        {
            if (_root != null)
                return _root.Value;
            return -1;
        }

        public void PrintNodes()
        {
            while(_root != null)
            {
                Console.WriteLine(_root.Value);
                _root = _root.Next;
            }
        }
    }
    #endregion

    #region Node
    public class Node
    {
        private int _value;
        public int Value { get { return _value; } }
        public Node(int value)
        {
            _value = value;
        }

        public Node Prev;
        public Node Next;
    }
    #endregion

    #region BST - Misc
    public class BST
    {
        public int HighestLeft { get; set; }
        public int LowestRight { get; set; }
        public int Height { get; set; }
    }
    #endregion

    #region Binary Node
    public class BinaryNode
    {
        private int _value;
        public int Value { get { return _value; } }
        public BinaryNode(int value)
        {
            _value = value;
        }

        public BinaryNode Left;
        public BinaryNode Right;
    }
    #endregion
}
