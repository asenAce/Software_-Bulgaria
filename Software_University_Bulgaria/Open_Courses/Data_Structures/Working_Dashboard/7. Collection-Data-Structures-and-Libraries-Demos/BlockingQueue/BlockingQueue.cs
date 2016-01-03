using System;
using System.Collections.Concurrent;
using System.Threading;

class BlockingQueue
{
    static BlockingCollection<string> tasks = new BlockingCollection<string>();

    private static void Consumer()
    {
        while (true)
        {
            var task = tasks.Take();
            Console.WriteLine("Executing task {0} ...", task);
            Thread.Sleep(2000);
            Console.WriteLine("Task {0} finished.", task);
        }
    }

    static void Main()
    {
        // Start 3 consumers (task executors)
        for (int i = 0; i < 3; i++)
            (new Thread(Consumer)).Start();

        // Start the producer
        while (true)
        {
            Console.WriteLine("Press [Enter] to produce new task");
            Console.ReadLine();
            var task = "Task" + DateTime.Now.Ticks;
            tasks.Add(task);
        }
    }
}
