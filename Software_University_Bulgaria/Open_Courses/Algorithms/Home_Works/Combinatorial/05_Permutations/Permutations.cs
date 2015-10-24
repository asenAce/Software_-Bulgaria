using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Permutations
{

    /*
     *Task five Problem 5.	PermutationsWithRepetition
     * */


    class Permutations
    {
        static int totalPermutations = 0;

        static void Main()
        {
            //int[] set = new int[] { 1, 2, 3 };
            //int[] set = new int[] { 1, 3, 3 };
            //int[] set = new int[] { 1, 2, 3, 4 };
            //int[] set = new int[] { 1, 3, 5, 5 };
            //int[] set = new int[] { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            //int[] set = new int[] { 5, 1, 3, 5, 5 };
            int[] set = new int[] { 1, 5, 5, 7, 7, 7, 1 };

            OccurrencesCounter<int> setCounter = new OccurrencesCounter<int>();
            for (var i = 0; i < set.Length; i++)
            {
                setCounter.Add(set[i]);
            }
            Console.WriteLine(setCounter.ToString());

            int[] arr = new int[set.Length];
            bool[] busy = new bool[set.Length];
            permute(setCounter, set.Length, 0, 0, -1, arr, busy);
            Console.WriteLine("Total Items in Set: {0}", set.Length);
            Console.WriteLine("Total Permutations: {0}", totalPermutations);
        }

        static void permute(OccurrencesCounter<int> set, int n, int numberIndex, int numberOccurenceIndex, int numberLastIndexPlacement, int[] arr, bool[] busy)
        {
            if (numberIndex >= set.Count)
            {
                Print(arr);
                totalPermutations++;
            }
            else
            {
                KeyValuePair<int, int> currNumber = set[numberIndex];
                if (numberOccurenceIndex >= currNumber.Value)
                {
                    permute(set, n, numberIndex + 1, 0, -1, arr, busy);
                }
                else
                {
                    var start = Math.Max(numberOccurenceIndex, numberLastIndexPlacement);
                    var end = n + numberOccurenceIndex - currNumber.Value + 1;
                    for (var i = start; i < end; i++)
                    {
                        if (busy[i]) continue;
                        arr[i] = currNumber.Key;
                        busy[i] = true;
                        permute(set, n, numberIndex, numberOccurenceIndex + 1, i, arr, busy);
                        busy[i] = false;
                    }
                }
            }
        }

        private static void Print(int[] array)
        {
            Console.WriteLine("{{ {0} }}", string.Join(", ", array));
        }
    }

    public class OccurrencesCounter<T>
    {
        public class ListNode<T>
        {
            public T Value { get; private set; }
            public int OccurrencesCount { get; set; }
            public ListNode<T> NextNode { get; set; }
            public ListNode()
            {
            }
            public ListNode(T value, ListNode<T> next)
            {
                this.Value = value;
                this.NextNode = next;
                this.OccurrencesCount = 0;
            }
        }

        private ListNode<T> Head;
        private ListNode<T> Tail;
        public int Count { get; private set; }

        public void Add(T value)
        {
            if (this.Count == 0)
            {
                var node = new ListNode<T>(value, null);
                node.OccurrencesCount++;
                this.Head = node;
                this.Tail = node;
                this.Count++;
            }
            else
            {
                bool found = false;
                ListNode<T> temp = null;
                for (var i = 0; i < this.Count; i++)
                {
                    if (i == 0) temp = this.Head;

                    if (value.Equals(temp.Value))
                    {
                        temp.OccurrencesCount++;
                        found = true;
                        break;
                    }
                    temp = temp.NextNode;
                }

                if (found == false)
                {
                    var node = new ListNode<T>(value, null);
                    node.OccurrencesCount++;
                    this.Tail.NextNode = node;
                    this.Tail = node;
                    this.Count++;
                }
            }
        }

        public Dictionary<T, int> ToDictionary()
        {
            Dictionary<T, int> dict = new Dictionary<T, int>();
            ListNode<T> temp = null;
            for (var i = 0; i < this.Count; i++)
            {
                if (i == 0)
                {
                    temp = this.Head;
                }
                dict[temp.Value] = temp.OccurrencesCount;
                temp = temp.NextNode;
            }
            return dict;
        }

        public KeyValuePair<T, int> this[int index]
        {
            get
            {
                if (index >= this.Count)
                {
                    throw new IndexOutOfRangeException("OccurrencesCounter indexer problem.");
                }
                ListNode<T> temp = null;
                for (var i = 0; i < this.Count; i++)
                {
                    if (i == 0)
                    {
                        temp = this.Head;
                    }
                    if (i == index)
                    {
                        return new KeyValuePair<T, int>(temp.Value, temp.OccurrencesCount);
                    }
                    temp = temp.NextNode;
                }
                return new KeyValuePair<T, int>();
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            ListNode<T> temp = new ListNode<T>();
            for (var i = 0; i < this.Count; i++)
            {
                if (i == 0)
                {
                    temp = this.Head;
                }
                str.Append(string.Format("{0} => {1}\n", temp.Value, temp.OccurrencesCount));
                temp = temp.NextNode;
            }
            return str.ToString();
        }
    }
}
