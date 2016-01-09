using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArrayBasedStack
{
    class ArrayStackTest
    {
        #region [Test Class]
            public class ArrayStackTest
            {
                #region [Test Method]
                public void Push Pop Elements()
                {
                    var nums = new ArrayStack<int>();
                    Assert.AreEqual(0,nums.Count);
                    nums.Push(15);
                    Assert.AreEqual(1,nums.Count);
                    Assert.AreEqual(15,nums.Pop());
                    Assert.AreEqual(0,nums.Count);
                }

                #endregion [Test Method]

                #region [Test Method Two]
                    public void Push Pop 1000 Elements()
                    {
                        var nums = new ArrayStack<int>();
                        Assert.AreEqual(0,nums.Count);

                        for (int i = 0; i < 1001; i++)
		                	{
			                    nums.Push(i);
                                Assert.AreEqual(i + 1, nums.Count);    
		                	}
                        for (int i = 0; i < 1001; i++)
		                	{
			                    Assert.AreEqual(1000 - i,nums.Pop());
                                Assert.AreEqual(1000 - i,nums.Count);
	                		}
                    }
                
                #endregion [Test Method Two]
                          }
                #region InvalidOperationException
                    public void Pop Empty Stack()
                    {
                        var nums = new ArrayStack<int>();
                        nums.Pop();
                    }

                #endregion InvalidOperationException

                #region [Test Method Three]
                    public void Pop Push Initial Capacity 1()
                    {
                            var nums = new ArrayStack<int>(1);
                            Assert.AreEqual(0, nums.Count);
                            nums.Push(15);
                            Assert.AreEqual(1,nums.Count);
                            nums.Push(12);
                            Assert.AreEqual(2,nums.Count);
                            Assert.AreEqual(12,nums.Pop());
                            Assert.AreEqual(1,nums.Count);
                            Assert.AreEqual(15,nums.Pop());
                            Assert.AreEqual(0,nums.Count);
                    }

                #endregion [Test Method Three]
                public void To Array()
                    {
                        var nums = new ArrayStack<int>();
                        
                        nums.Push(3);
                        nums.Push(5);
                        nums.Push(-2);
                        nums.Push(7);

                        int[] arrTest = {7, -2 , 5 , 3};
                        CollectionAssert.AreEqual(arrTest,nums.ToArray());
                    }
                public void To Array Empty()
                    {
                        var data = new ArrayStack<DateTime>();
                        var arrTest = new DateTime[0];

                        CollectionAssert.AreEqual(arrTest,dates.ToArray());
                    }


        #endregion [Test Class]
            
    }
}
