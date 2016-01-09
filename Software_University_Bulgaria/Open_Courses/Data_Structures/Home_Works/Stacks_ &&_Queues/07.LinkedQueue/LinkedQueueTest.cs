
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LinkedQueue
{
    class LinkedQueueTest
    {
       
        [TestMethod]
        public void Enqueue_Dequeue_Elements()
        {
            var nums = new LinkedQueue<int>();
            Assert.AreEqual(0, nums.Count);
            nums.Enqueue(15);
            Assert.AreEqual(1, nums.Count);
            nums.Enqueue(12);
            Assert.AreEqual(2, nums.Count);
            Assert.AreEqual(15, nums.Dequeue());
            Assert.AreEqual(1, nums.Count);
            Assert.AreEqual(12, nums.Dequeue());
            Assert.AreEqual(0, nums.Count);
        }

        [TestMethod]
        public void Enqueue_Dequeue_1000_Elements()
        {
            var nums = new LinkedQueue<int>();
            Assert.AreEqual(0, nums.Count);

            for (int i = 0; i < 1001; i++)
            {
                nums.Enqueue(i);
                Assert.AreEqual(i + 1, nums.Count);
            }
            for (int i = 0; i < 1001; i++)
            {
                Assert.AreEqual(i, nums.Dequeue());
                Assert.AreEqual(1000 - i, nums.Count);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Dequeue_Empty_Stack()
        {
            var nums = new LinkedQueue<int>();
            nums.Dequeue();
        }

        [TestMethod]
        public void To_Array()
        {
            var nums = new LinkedQueue<int>();
            nums.Enqueue(3);
            nums.Enqueue(5);
            nums.Enqueue(-2);
            nums.Enqueue(7);
            int[] arrTest = { 3, 5, -2, 7 };
            CollectionAssert.AreEqual(arrTest, nums.ToArray());
        }

        [TestMethod]
        public void To_Array_Empty()
        {
            var dates = new LinkedQueue<DateTime>();
            var arrTest = new DateTime[0];

            CollectionAssert.AreEqual(arrTest, dates.ToArray());
        }
    }

            
    





    

