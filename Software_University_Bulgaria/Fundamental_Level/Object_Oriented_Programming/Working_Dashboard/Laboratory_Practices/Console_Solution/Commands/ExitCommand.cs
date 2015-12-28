using ConsoleForum.Contracts;
using System;

namespace ConsoleForum.Commands
{
    public class ExitCommand : AbstractCommand
    {
        public ExitCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            this.Forum.HasStarted = false;
        }
    }
}
