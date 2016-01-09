using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01.PostFixCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region The Input "The God":
                //The stack of integers not yet operated on
            Stack<int> values = new Stack<int>();
            #endregion The Input "The God":
            #region The Logic "The Bad":
            #region foreach Loop:
            foreach (var token in args)
            {
                //if the value is an integer....
                int value;
                #region if Loop:
                if (int.TryParse(token,out value))
                {
                    //.....push it on the stack
                    values.Push(values);
                }
                else
                {
                    //Otherwise evaluate the expresion....
                    int rhs = values.Pop();
                    int lhs = values.Pop();
                    #region switch Loop:
                        //and pop the result back to the stack.
                    switch (token)
                    {
                        case"+":
                            values.Push(lhs + rhs);
                            break;
                        case"-":
                            values.Push(lhs - rhs);
                            break;
                        case"*":
                            values.Push(lhs * rhs);
                            break;
                        case"/":
                            values.Push(lhs / rhs);
                            break;
                        case"%":
                            values.Push(lhs % rhs);
                            break;
                        default: 
                            throw new ArgumentException(string.Format("Unrecognized token: {0}", token));
                    }

                    #endregion switch Loop:


                }
                #endregion if Lopp:
            }

            #endregion foreach Loop:

            #endregion The Logic "The Bad":
            #region The Output "The Ugly":



            #endregion The Output"The Ugly":
        }
    }
}
