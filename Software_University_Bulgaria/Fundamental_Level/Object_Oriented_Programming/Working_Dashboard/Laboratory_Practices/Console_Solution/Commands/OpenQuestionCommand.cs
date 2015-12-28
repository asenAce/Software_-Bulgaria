using ConsoleForum.Contracts;
using System;
using System.Linq;

namespace ConsoleForum.Commands
{
    public class OpenQuestionCommand : AbstractCommand
    {
        public OpenQuestionCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            int questionId = int.Parse(this.Data[1]);
            var question = this.Forum.Questions
                .FirstOrDefault(q => q.Id == questionId);
            if (question == null)
            {
                throw new CommandException(Messages.NoQuestion);
            }

            this.Forum.CurrentQuestion = question;
            this.Forum.Output.AppendLine(question.ToString());
        }
    }
}
