namespace ConsoleForum
{
    using ConsoleForum.Contracts;
    using System;
    using System.IO;

    public class ConsoleForumMain
    {
        public static void Main()
        {
            //var output = new StreamWriter("../../out.txt");
            //using (output)
            //{
            //    Console.SetOut(output);
            IForum forum = new Forum();
            forum.Run();
        }
        //}
    }
}
