using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01.ArrayStack
{
    class ArrayStackTests
    {
        [TestMethod]
        public void TestPushPopElement()
        {
            var stack = new ArrayStack<int>();
            Assert.AreEqual(0, stack.Count);

            stack.Push(1);
            Assert.AreEqual(1, stack.Count);

            stack.Pop();
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void TestPush_1000_Elements()
        {
            var stack = new ArrayStack<int>();
            Assert.AreEqual(0, stack.Count);

            for (int i = 0; i < 1000; i++)
            {
                stack.Push(i);
                Assert.AreEqual(i + 1, stack.Count);
            }

            for (int i = 0; i < 1000; i++)
            {
                stack.Pop();
                Assert.AreEqual(1000 - i - 1, stack.Count);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestPopFromEmptyStack()
        {
            var stack = new ArrayStack<int>();
            stack.Pop();
        }

        [TestMethod]
        public void TestPopPushInitialCapacity_1()
        {
            var stack = new ArrayStack<int>(1);
            Assert.AreEqual(0, stack.Count);

            stack.Push(27);
            Assert.AreEqual(1, stack.Count);

            stack.Push(108);
            Assert.AreEqual(2, stack.Count);

            stack.Pop();
            Assert.AreEqual(1, stack.Count);

            stack.Pop();
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void TestStackToArrayAfterPushingNubers()
        {
            var stack = new ArrayStack<int>();
            int[] arrayWithOrigins = { 3, 5, -2, 7 };

            for (int i = 0; i < arrayWithOrigins.Length; i++)
            {
                stack.Push(arrayWithOrigins[i]);
            }

            int[] stackToArray = stack.ToArray();

            for (int i = 0; i < arrayWithOrigins.Length; i++)
            {
                Assert.AreEqual(arrayWithOrigins[stack.Count - i - 1], stackToArray[i]);
            }
        }

        [TestMethod]
        public void TestEmptyStackToArray()
        {
            var stack = new ArrayStack<DateTime>();
            DateTime[] array = stack.ToArray();

            Assert.AreEqual(0, array.Length);
        }

        [TestMethod]
        public void TestPeakAfterPushPopElement()
        {
            var stack = new ArrayStack<int>();

            stack.Push(10);
            stack.Push(20);
            Assert.AreEqual(20, stack.Peek());
            stack.Pop();
            Assert.AreEqual(10, stack.Peek());
        }

        [TestMethod]
        public void TestCountAfterPushing()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(3, stack.Count);
        }

        [TestMethod]
        public void TestCountAfterPoping()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Pop();
            Assert.AreEqual(1, stack.Count);
        }    


    }
}
