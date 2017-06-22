using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Input 1.1 :: Is Unique String
                //Console.WriteLine(ArraysAndString.IsUnique("abcd"));
                //Console.WriteLine(ArraysAndString.IsUnique("  "));
                #endregion

                #region Input 1.2 :: Reverse C-Style String
                //Console.WriteLine(ArraysAndString.ReverseCStyleSting("abcd0"));
                #endregion

                #region Input 1.3 :: Remove duplicates from String
                //Console.WriteLine(ArraysAndString.RemoveDuplicates("abcd"));
                //Console.WriteLine(ArraysAndString.RemoveDuplicates("a"));
                //Console.WriteLine(ArraysAndString.RemoveDuplicates(" "));
                //Console.WriteLine(ArraysAndString.RemoveDuplicates("abcabc"));
                //Console.WriteLine(ArraysAndString.RemoveDuplicates("aaabbbcccc"));
                #endregion

                #region Input 1.4 :: Anagrams ?
                //Console.WriteLine(ArraysAndString.Anagrams("abcd", "dbca")); //True
                //Console.WriteLine(ArraysAndString.Anagrams("abcd", "abcd")); //True
                //Console.WriteLine(ArraysAndString.Anagrams("ishh", "hhis")); //True
                //Console.WriteLine(ArraysAndString.Anagrams("hhhhhhhhhi", "hhhhihhhhh")); //True
                //Console.WriteLine(ArraysAndString.Anagrams("ishh", "hiss")); //False
                //Console.WriteLine(ArraysAndString.Anagrams("ish", "hiss")); //False
                //Console.WriteLine(ArraysAndString.Anagrams("", "")); //False
                #endregion

                #region Input 1.5 :: Replace Space with %20
                //Console.WriteLine(ArraysAndString.ReplaceSpaceWith20("a c"));
                //Console.WriteLine(ArraysAndString.ReplaceSpaceWith20("abc"));
                //Console.WriteLine(ArraysAndString.ReplaceSpaceWith20(" "));
                #endregion

                #region Input 1.6 :: Rotate N*N matrix by 90 degree
                /*var input = new int[3][];
                input[0] = new int[3] { 1, 2, 3 };
                input[1] = new int[3] { 4, 5, 6 };
                input[2] = new int[3] { 7, 8, 9 };*/
                /*var input = new int[5][];
                input[0] = new int[5] { 1, 2, 3, 4, 5 };
                input[1] = new int[5] { 6, 7, 8, 9, 10 };
                input[2] = new int[5] { 11, 12, 13, 14, 15 };
                input[3] = new int[5] { 16, 17, 18, 19, 20 };
                input[4] = new int[5] { 21, 22, 23, 24, 25 };
                ArraysAndString.RotateMatrix(input, 3);*/
                #endregion

                #region Row Product Calculator
                /*var input = new int[3][];
                input[0] = new int[3] { 1, 2, 3 };
                input[1] = new int[3] { 0, 1, 16 };
                input[2] = new int[3] { 3, 3, 1 };
                ArraysAndString.RowProductCalculator(input);
                for (var i = 0; i < input.Length; i++)
                {
                    if (input[i] != null)
                    {
                        for (var j = 0; j < input[i].Length; j++)
                        {
                            Console.Write(input[i][j] + " ");
                        }
                        Console.WriteLine();
                    }
                }*/
                #endregion

                #region Input 1.7 :: Set Column/Row to 0 if element with 0 is identified
                /*var input = new int[3][];
                input[0] = new int[3] { 1, 2, 3 };
                input[1] = new int[3] { 0, 1, 16 };
                input[2] = new int[3] { 3, 3, 1 };
                ArraysAndString.SetRowColumnToZero(input);
                for (var i = 0; i < input.Length; i++)
                {
                    if (input[i] != null)
                    {
                        for (var j = 0; j < input[i].Length; j++)
                        {
                            Console.Write(input[i][j] + " ");
                        }
                        Console.WriteLine();
                    }
                }*/
                #endregion

                #region Solution 1.8 :: StringRotation
                //var str1 = "vivian";
                //var str2 = "vianvi";
                /*var str1 = "apple";
                var str2 = "pleap";
                Console.WriteLine(ArraysAndString.StringRotation(str1, str2));*/
                #endregion

                #region Queue Input
                /*try
                {
                    var ds = new MyQueue(3);
                    ds.Enqueue(1);
                    ds.Enqueue(2);
                    ds.Enqueue(3);
                    //ds.Enqueue(4);
                    Console.WriteLine(ds.Dequeue());
                    Console.WriteLine(ds.Dequeue());
                    Console.WriteLine(ds.Dequeue());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }*/
                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

    #region Arrays and Strings
    public class ArraysAndString
    {
        #region Solution 1.1 :: Is Unique String
        public static bool IsUnique(string input)
        {
            var charSet = new bool[256]; //ASCII character set
            for (var i = 0; i < input.Length; i++)
            {
                var intValue = Convert.ToInt32(input[i]);
                if (charSet[intValue])
                    return false;
                charSet[intValue] = true;
            }
            return true;
        }
        #endregion

        #region Solution 1.2 :: Reverse C-Style String
        public static string ReverseCStyleSting(string input)
        {
            var reverseString = new StringBuilder(input.Length);
            for (var i = input.Length - 2; i >= 0; i--)
            {
                reverseString.Append(input[i]);
            }
            reverseString.Append(input[input.Length - 1]);
            return $"Reversed string :: {reverseString.ToString()}";
        }
        #endregion

        #region Solution 1.3 :: Remove duplicates from String
        public static string RemoveDuplicates(string input)
        {
            if (input.Length < 2)
                return $"Duplicates Removed string :: {input}";

            var duplicateRemoval = new StringBuilder();            
            for (var i = 0; i < input.Length; i++)
            {
                var duplicate = false;
                for (var j = 0; j < duplicateRemoval.Length; j++)
                {
                    if (input[i] == duplicateRemoval[j])
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
                {
                    duplicateRemoval.Append(input[i]);
                }
            }
            return $"Duplicates Removed string :: {duplicateRemoval.ToString()}";
        }
        #endregion

        #region Solution 1.4 :: Anagrams ?
        public static bool Anagrams(string str1, string str2)
        {
            //Other solution is to sort both the strings and do a comparison.
            //var charStr1 = str1.ToCharArray();
            //var charStr2 = str2.ToCharArray();
            //Array.Sort(charStr1);
            //Array.Sort(charStr2);            
            //Compare both the char arrays and return the output

            if (str1.Length != str2.Length)
                return false;

            if (str1.Length == 0 && str2.Length == 0)
                throw new ArgumentException("Strings can't be empty for Anagram determination");

            var asciiCharSet = new int[256];
            for (var i = 0; i < str1.Length; i++)
            {
                var charCode = Convert.ToInt32(str1[i]);
                asciiCharSet[charCode] += 1;
            }
            for (var i = 0; i < str2.Length; i++)
            {
                var charCode = Convert.ToInt32(str2[i]);
                if (asciiCharSet[charCode] <= 0)
                    return false;
                asciiCharSet[charCode] -= 1;
            }
            return true;
        }
        #endregion

        #region Solution 1.5 :: Replace Space with %20
        public static string ReplaceSpaceWith20(string input)
        {
            var replacedString = new StringBuilder();
            for(var i = 0; i < input.Length; i++)
            {
                if (Convert.ToInt32(input[i]) == 32)
                    replacedString.Append("%20");
                else
                    replacedString.Append(input[i]); 
            }
            return replacedString.ToString();
        }
        #endregion

        #region Solution 1.6 :: Rotate N*N matrix by 90 degree
        public static void RotateMatrix(int[][] input)
        {
            var matrix = new int[input.Length][];
            for (var i = 0; i < input.Length; i++)
            {
                matrix[i] = new int [input[i].Length];
            }

            var index = 0;
            for (var i = input.Length - 1; i >= 0; i--)
            {
                for (var j = 0; j < input[i].Length; j++)
                {
                    matrix[j][index] = input[i][j];
                }
                index++;
            }

            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void RotateMatrix(int[][] matrix, int n)
        {
            for (var layer = 0; layer < n/2; layer++)
            {
                var first = layer;
                var last = (n - 1 - layer);

                for (var i = first; i < last; i++)
                {
                    var offset = i - first;
                    //Top -> temp
                    var temp = matrix[first][i];
                    //Left -> Top
                    matrix[first][i] = matrix[last - offset][first];
                    //Bottom -> Left
                    matrix[last - offset][first] = matrix[last][last - offset];
                    //Right -> Bottom
                    matrix[last][last - offset] = matrix[i][last];
                    //temp -> Right
                    matrix[i][last] = temp;
                }
            }

            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix.Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Row Product Calculator
        public static void RowProductCalculator(int[][] input)
        {
            if (input == null)
                throw new ArgumentException("Input array can't be null", nameof(input));
            
            var length = input.Length;
            if (length <= 0)
                throw new ArgumentException("Input array can't be of length Zero", nameof(input));

            for (var i = 0; i < length; i++)
            {
                var product = 1;
                if (input[i] != null)
                {
                    for (var j = 0; j < input[i].Length; j++)
                    {
                        product *= input[i][j];
                    }
                    for (var j = 0; j < input[i].Length; j++)
                    {
                        input[i][j] = product;
                    }
                }
            }
        }
        #endregion

        #region Solution 1.7 :: Set Column/Row to 0 if element with 0 is identified
        public static void SetRowColumnToZero(int[][] input)
        {
            if (input == null)
                throw new ArgumentException("Input array can't be null", nameof(input));

            var length = input.Length;
            if (length <= 0)
                throw new ArgumentException("Input array can't be of length Zero", nameof(input));
            
            var xAxis = new int[input.Length];
            var yAxis = new int[input[0] == null ? input.Length : input[0].Length];

            for (var i = 0; i < length; i++)
            {
                if (input[i] != null)
                {
                    for (var j = 0; j < input[i].Length; j++)
                    {
                        if (input[i][j] == 0)
                        {
                            xAxis[i] = 1;
                            yAxis[j] = 1;
                        }
                    }
                }
            }

            for (var i = 0; i < length; i++)
            {
                if (input[i] != null)
                {
                    for (var j = 0; j < input[i].Length; j++)
                    {
                        if (xAxis[i] == 1 || yAxis[j] == 1)
                            input[i][j] = 0;
                    }
                }
            }

            /*for (var i = 0; i < xAxis.Length; i++)
            {
                if (xAxis[i] == true)
                {
                    var rowLength = input[i].Length;
                    for (var j = 0; j < rowLength; j++)
                    {
                        input[i][j] = 0;
                    }
                }
            }

            for (var j = 0; j < yAxis.Length; j++)
            {
                if (yAxis[j] == true)
                {
                    var columnLength = input.Length;
                    for (var i = 0; i < columnLength; i++)
                    {
                        input[i][j] = 0;
                    }
                }
            }*/
        }
        #endregion

        #region Solution 1.8 :: StringRotation
        public static bool StringRotation(string str1, string str2)
        {
            //Optimal solution
            //str1 + str1 and check if str2 is a substring of concatenated string
            //pleap + pleap will give pleappleap and apple is a substring of it. 

            if (str1.Length != str2.Length)
                return false;

            var charArray1 = str1.ToCharArray();
            var charArray2 = str2.ToCharArray();
            var length = str1.Length;
            
            for (var i = 0; i < length; i++)
            {
                if (str1[i] == str2[0])
                {
                    if (charArray1[(length + i - 1) % length] != charArray2[str2.Length - 1])
                    {
                        continue;
                    }

                    var substr1 = new string(charArray1, i, length - i) + new string(charArray1, 0, i);
                    var substr2 = new string(charArray2);
                    return IsSubString(substr1, substr2);
                }
            }
            return false;
        }

        private static bool IsSubString(string str1, string str2)
        {
            if (str1.GetHashCode() == str2.GetHashCode())
                return true;
            return false;
        }
        #endregion

        #region HashTable
        public Hashtable BuildHashTable(Student[] students)
        {
            var studentHash = new Hashtable();
            foreach (var student in students)
            {
                studentHash.Add(student.Id, student);
            }
            return studentHash;
        }
        #endregion

        #region Dictionary
        public Dictionary<int, Student> BuildDictionary(Student[] students)
        {
            var studentDictionary = new Dictionary<int, Student>();
            foreach (var student in students)
            {
                studentDictionary.Add(student.Id, student);
            }
            return studentDictionary;
        }
        #endregion

        #region HashSet
        public HashSet<Student> BuildHashSet(Student[] students)
        {
            var studentSet = new HashSet<Student>();
            foreach(var student in students)
            {
                studentSet.Add(student);
            }
            return studentSet;
        }
        #endregion

        #region ArrayList
        public ArrayList BuildArrayList(string[] words, string[] more)
        {
            var sentence = new ArrayList();
            foreach(var word in words)
            {
                sentence.Add(word);
            }
            foreach(var m in more)
            {
                sentence.Add(m);
            }
            return sentence;
        }
        #endregion

        #region String Sentence
        public string BuildString(string[] words)
        {
            var sentence = string.Empty;
            foreach(var word in words)
            {
                sentence += word;
            }
            return sentence;
        }
        #endregion

        #region String Builder
        public string BuildStringBuilder(string[] words)
        {
            var sentence = new StringBuilder();
            foreach (var word in words)
            {
                sentence.Append(word);
            }
            return sentence.ToString();
        }
        #endregion
    }
    #endregion

    #region Queue - My Implementation
    public class MyQueue
    {
        private int _capacity;
        private int[] _arrQ;
        private int _end = 0;
        private int _start = 0;
        private int _count = 0;

        public MyQueue(int capacity)
        {
            this._capacity = capacity;
            _arrQ = new int[_capacity];
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _capacity;
        }

        public void Enqueue(int i)
        {
            if (IsFull())
            {
                throw new ApplicationException("Queue full");
            }
            else
            {
                _arrQ[_end % _capacity] = i;
                _end++;
                _count++;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new ApplicationException("Queue empty");
            }
            else
            {
                var j = _arrQ[_start % _capacity];
                _start++;
                _count--;
                return j;
            }
        }
    }
    #endregion

    #region Misc
    public class Misc
    {
        #region String Literals vs String Objects
        public void StringLiteralObject()
        {
            string abcd = "abcd";
            string abc = "abcd";
            Console.WriteLine(abcd == abc);
            Console.WriteLine(abc.Equals(abcd));

            string bcd = new string(new char[] { 'b', 'c', 'd' });
            string bc = new string(new char[] { 'b', 'c', 'd' });
            Console.WriteLine(bcd == bc);
            Console.WriteLine(bcd.Equals(bc));
        }
        #endregion

        #region Hash Code
        public void HashCode()
        {
            Console.WriteLine("abcd".GetHashCode());
        }
        #endregion

        #region Array Slice
        public void SliceArray()
        {
            var arr = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            var slice = new int[5 - 2];
            Array.Copy(arr, 2, slice, 0, slice.Length);

            foreach (var i in slice)
                Console.WriteLine(i);
        }
        #endregion
    }
    #endregion

    #region Student
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    #endregion
}
