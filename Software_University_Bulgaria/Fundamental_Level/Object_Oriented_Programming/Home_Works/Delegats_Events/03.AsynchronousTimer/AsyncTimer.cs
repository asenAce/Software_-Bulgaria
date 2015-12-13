using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.AsynchronousTimer
{
     public class AsyncTimer
    {
         private int ticks;
         private int interval;
         private string message;

         public AsyncTimer(Action<string> action, int ticks, int interval, string message)
         {
             this.Action = action;
             this.Ticks = ticks;
             this.Interval = interval;
             this.Message = message;

         }

         public Action<string> Action { get; private set; }

         public int Ticks 
         { 
             get
             {
                 return this.ticks;
             }
             private set
             {
                 if (value < 0)
                 {
                     throw new ArgumentOutOfRangeException("Incorrect");
                 }
                 this.ticks = value;
             }
         }
         public int Interval 
         { 
             get
             {
                 return this.interval;
             }
             private set
             {
                 if (value < 0)
                 {
                     throw new ArgumentOutOfRangeException("Incorrect");
                 }
                 this.interval = value;
             }
         }

         public string Message
         {
             get
             {
                 return this.message;
             }
             set
             {
                 if (string.IsNullOrEmpty(value))
                 {
                     throw new ArgumentNullException("Incorrct");
                 }
                 this.message = value;
             }
         }

         public void Run()
         {
             var parallel = new Thread(this.Execute);
             parallel.Start();
         }

         private void Execute()
         {
             for (int i = 0; i < this.ticks; i++)
             {
                 Thread.Sleep(this.Interval);
                 Console.WriteLine(this.Message);
             }
         }


    }
}
